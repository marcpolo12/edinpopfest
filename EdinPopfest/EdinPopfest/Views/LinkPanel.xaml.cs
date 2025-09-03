namespace EdinPopFest;

public partial class LinkPanel : ContentView
{
    public static readonly BindableProperty LinkHeaderProperty =
        BindableProperty.Create(nameof(LinkHeader), typeof(string), typeof(LinkPanel), string.Empty, propertyChanged: OnLinkHeaderChanged);

    public static readonly BindableProperty LinkInfoProperty =
        BindableProperty.Create(nameof(LinkInfo), typeof(string), typeof(LinkPanel), string.Empty, propertyChanged: OnLinkInfoChanged);

    public static readonly BindableProperty LinkTextProperty =
        BindableProperty.Create(nameof(LinkText), typeof(string), typeof(LinkPanel), string.Empty, propertyChanged: OnLinkTextChanged);

    public string LinkHeader
    {
        get => (string)GetValue(LinkHeaderProperty);
        set => SetValue(LinkHeaderProperty, value);
    }
    public string LinkInfo
    {
        get => (string)GetValue(LinkInfoProperty);
        set => SetValue(LinkInfoProperty, value);
    }
    public string LinkText
    {
        get => (string)GetValue(LinkTextProperty);
        set => SetValue(LinkTextProperty, value);
    }
    public LinkPanel()
    {
        InitializeComponent();
        this.linkTapGesture.Command = new Command(async () =>
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(LinkText))
                {
                    Uri uri;
                    if (Uri.TryCreate(LinkText, UriKind.Absolute, out uri))
                    {
                        await Launcher.Default.OpenAsync(LinkText);
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions (e.g., logging)
                //Console.WriteLine($"Error opening URL: {ex.Message}");
            }
        });
    }

    static void OnLinkHeaderChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (LinkPanel)bindable;
        control.linkHeader.Text = (string)newValue;
    }
    static void OnLinkInfoChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (LinkPanel)bindable;
        control.linkInfo.Text = (string)newValue;
    }
    static void OnLinkTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var control = (LinkPanel)bindable;
        //control.linkText.Text = (string)newValue;
    }

}