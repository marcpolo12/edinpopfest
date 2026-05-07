namespace EdinPopFest;

public partial class AlldayerPanel : ContentView
{
    public event EventHandler? Tapped;
    public static readonly BindableProperty AlldayerNameProperty =
        BindableProperty.Create(nameof(AlldayerName), typeof(string), typeof(AlldayerPanel), string.Empty, propertyChanged: OnAlldayerNameChanged);

    public static readonly BindableProperty AlldayerImageSourceProperty =
        BindableProperty.Create(nameof(AlldayerImageSource), typeof(ImageSource), typeof(AlldayerPanel), default(ImageSource), propertyChanged: OnAlldayerImageSourceChanged);

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
    public AlldayerPanel()
    {
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += (s, e) => Tapped?.Invoke(this, EventArgs.Empty);
        this.GestureRecognizers.Add(tapGesture);

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