namespace EdinPopFest;

public partial class BandPanel : ContentView
{
    public event EventHandler? Tapped;
    public static readonly BindableProperty BandNameProperty =
        BindableProperty.Create(nameof(BandName), typeof(string), typeof(BandPanel), string.Empty, propertyChanged: OnBandNameChanged);

    public static readonly BindableProperty BandTimeProperty =
        BindableProperty.Create(nameof(BandTime), typeof(string), typeof(BandPanel), string.Empty, propertyChanged: OnBandTimeChanged);

    public static readonly BindableProperty BandImageSourceProperty =
        BindableProperty.Create(nameof(BandImageSource), typeof(ImageSource), typeof(BandPanel), default(ImageSource), propertyChanged: OnBandImageSourceChanged);

    public string BandName
    {
        get => (string)GetValue(BandNameProperty);
        set => SetValue(BandNameProperty, value);
    }

    public string BandTime
    {
        get => (string)GetValue(BandTimeProperty);
        set => SetValue(BandTimeProperty, value);
    }

    public ImageSource BandImageSource
    {
        get => (ImageSource)GetValue(BandImageSourceProperty);
        set => SetValue(BandImageSourceProperty, value);
    }
    public BandPanel()
    {
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += (s, e) => Tapped?.Invoke(this, EventArgs.Empty);
        this.GestureRecognizers.Add(tapGesture);

        InitializeComponent();
    }

    static void OnBandNameChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (BandPanel)bindable;
        control.bandname.Text = (string)newValue;
    }

    static void OnBandTimeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (BandPanel)bindable;
        control.bandtime.Text = (string)newValue;
    }

    static void OnBandImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (BandPanel)bindable;
        control.bandimage.Source = (ImageSource)newValue;
    }
}