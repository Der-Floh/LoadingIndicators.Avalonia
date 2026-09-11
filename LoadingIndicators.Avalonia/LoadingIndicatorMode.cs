namespace LoadingIndicators.Avalonia;

/// <summary>
/// Selects which animation a <see cref="LoadingIndicator"/> shows. Each value is resolved at
/// runtime to the <see cref="global::Avalonia.Styling.ControlTheme"/> resource of the same name,
/// so a value only takes effect while the theme it names is present in the application resources.
/// </summary>
public enum LoadingIndicatorMode
{
    /// <summary>The <c>Arc</c> theme.</summary>
    Arc,

    /// <summary>The <c>ArcEase</c> theme.</summary>
    ArcEase,

    /// <summary>The <c>ArcGrow</c> theme.</summary>
    ArcGrow,

    /// <summary>The <c>Arcs</c> theme.</summary>
    Arcs,

    /// <summary>The <c>ArcsRing</c> theme.</summary>
    ArcsRing,

    /// <summary>The <c>Bounce</c> theme.</summary>
    Bounce,

    /// <summary>The <c>Plane</c> theme.</summary>
    Plane,

    /// <summary>The <c>Pulse</c> theme.</summary>
    Pulse,

    /// <summary>The <c>Circle</c> theme.</summary>
    Circle,

    /// <summary>The <c>Flow</c> theme.</summary>
    Flow,

    /// <summary>The <c>Wave</c> theme.</summary>
    Wave,

    /// <summary>The <c>Chase</c> theme.</summary>
    Chase,

    /// <summary>The <c>CircleFade</c> theme.</summary>
    CircleFade,

    /// <summary>The <c>Swing</c> theme.</summary>
    Swing,

    /// <summary>The <c>Grid</c> theme.</summary>
    Grid,

    /// <summary>The <c>Fold</c> theme.</summary>
    Fold,

    /// <summary>The <c>Wander</c> theme.</summary>
    Wander,

    /// <summary>The <c>DualRing</c> theme.</summary>
    DualRing,

    /// <summary>The <c>Ripple</c> theme.</summary>
    Ripple,

    /// <summary>The <c>Spinner</c> theme.</summary>
    Spinner
}
