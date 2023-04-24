using System.Windows.Input;

namespace ColViewStackIsVisible;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		collection.ItemsSource = new object[]
		{
			new object(),
			new object(),
			new object(),
			new object()

		};
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Resources["show-label"] = !(bool)Resources["show-label"];
    }
}

