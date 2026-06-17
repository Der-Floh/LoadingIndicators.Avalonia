using Avalonia;
using Avalonia.VisualTree;

namespace LoadingIndicators.Avalonia;

public sealed class AncestorPropertyTracker
{
    private readonly Visual _target;
    private readonly AvaloniaProperty _property;
    private readonly List<Visual> _ancestors = [];

    public AncestorPropertyTracker(Visual target, AvaloniaProperty property)
    {
        _target = target;
        _property = property;
    }

    public event EventHandler? Changed;

    public void Rebuild()
    {
        Clear();
        foreach (var ancestor in _target.GetVisualAncestors())
        {
            ancestor.PropertyChanged += OnAncestorPropertyChanged;
            _ancestors.Add(ancestor);
        }
    }

    public void Clear()
    {
        foreach (var ancestor in _ancestors)
        {
            ancestor.PropertyChanged -= OnAncestorPropertyChanged;
        }
        _ancestors.Clear();
    }

    private void OnAncestorPropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
    {
        if (e.Property == _property)
            Changed?.Invoke(this, EventArgs.Empty);
    }
}
