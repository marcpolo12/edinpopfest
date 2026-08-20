namespace EdinPopFest;

public partial class AlldayerPanel : ContentView
{
    public event EventHandler? Tapped;

    public static readonly BindableProperty AlldayerNameProperty =
        BindableProperty.Create(nameof(AlldayerName), typeof(string), typeof(AlldayerPanel), string.Empty, propertyChanged: OnAlldayerNameChanged);

    public static readonly BindableProperty AlldayerImageSourceProperty =
        BindableProperty.Create(nameof(AlldayerImageSource), typeof(ImageSource), typeof(AlldayerPanel), default(ImageSource), propertyChanged: OnAlldayerImageSourceChanged);

    public static readonly BindableProperty PanelOpacityProperty =
        BindableProperty.Create(nameof(PanelOpacity), typeof(double), typeof(AlldayerPanel), 0.90);

    public static readonly BindableProperty PanelBackgroundColorProperty =
        BindableProperty.Create(nameof(PanelBackgroundColor), typeof(Color), typeof(AlldayerPanel), Colors.PeachPuff);

    public static readonly BindableProperty TextColorProperty =
        BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(AlldayerPanel), Colors.Navy);

    public string AlldayerName
    {
        get => (string)GetValue(AlldayerNameProperty);
        set => SetValue(AlldayerNameProperty, value);
    }

    public ImageSource AlldayerImageSource
    {
        get => (ImageSource)GetValue(AlldayerImageSourceProperty);
        set => SetValue(AlldayerImageSourceProperty, value);
    }

    public double PanelOpacity
    {
        get => (double)GetValue(PanelOpacityProperty);
        set => SetValue(PanelOpacityProperty, value);
    }

    public Color PanelBackgroundColor
    {
        get => (Color)GetValue(PanelBackgroundColorProperty);
        set => SetValue(PanelBackgroundColorProperty, value);
    }

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public AlldayerPanel()
    {
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += (s, e) => Tapped?.Invoke(this, EventArgs.Empty);
        GestureRecognizers.Add(tapGesture);

        InitializeComponent();
    }

    static void OnAlldayerNameChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (AlldayerPanel)bindable;
        control.alldayername.Text = (string)newValue;
    }

    static void OnAlldayerTimeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (AlldayerPanel)bindable;
    }

    static void OnAlldayerImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (AlldayerPanel)bindable;
        control.alldayerimage.Source = (ImageSource)newValue;
    }
}