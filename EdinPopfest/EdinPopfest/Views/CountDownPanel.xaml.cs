namespace EdinPopFest;

public partial class CountDownPanel : ContentView
{

    public static readonly BindableProperty CountDownMessageProperty =
        BindableProperty.Create(nameof(CountDownMessage), typeof(string), typeof(CountDownPanel), string.Empty, propertyChanged: OnCountDownMessageChanged);
    public static readonly BindableProperty DaysProperty =
        BindableProperty.Create(nameof(Days), typeof(string), typeof(CountDownPanel), string.Empty, propertyChanged: OnDaysChanged);
    public static readonly BindableProperty HoursProperty =
        BindableProperty.Create(nameof(Hours), typeof(string), typeof(CountDownPanel), string.Empty, propertyChanged: OnHoursChanged);
    public static readonly BindableProperty MinutesProperty =
        BindableProperty.Create(nameof(Minutes), typeof(string), typeof(CountDownPanel), string.Empty, propertyChanged: OnMinutesChanged);
    public static readonly BindableProperty SecondsProperty =
        BindableProperty.Create(nameof(Seconds), typeof(string), typeof(CountDownPanel), string.Empty, propertyChanged: OnSecondsChanged);
    public string CountDownMessage
    {
        get => (string)GetValue(CountDownMessageProperty);
        set => SetValue(CountDownMessageProperty, value);
    }
    public string Days
    {
        get => (string)GetValue(DaysProperty);
        set => SetValue(DaysProperty, value);
    }
    public string Hours
    {
        get => (string)GetValue(HoursProperty);
        set => SetValue(HoursProperty, value);
    }
    public string Minutes
    {
        get => (string)GetValue(MinutesProperty);
        set => SetValue(MinutesProperty, value);
    }
    public string Seconds
    {
        get => (string)GetValue(SecondsProperty);
        set => SetValue(SecondsProperty, value);
    }
    public CountDownPanel()
	{
		InitializeComponent();
	}
    static void OnCountDownMessageChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CountDownPanel)bindable;
        control.countdownmsg.Text = (string)newValue;
    }
    static void OnDaysChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CountDownPanel)bindable;
        control.days.Text = (string)newValue;
    }
    static void OnHoursChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CountDownPanel)bindable;
        control.hours.Text = (string)newValue;
    }
    static void OnMinutesChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CountDownPanel)bindable;
        control.minutes.Text = (string)newValue;
    }
    static void OnSecondsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CountDownPanel)bindable;
        control.seconds.Text = (string)newValue;
    }
}