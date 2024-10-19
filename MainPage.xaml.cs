namespace _25371_repro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGoToSecondPageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SecondPage());
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		Console.WriteLine("MainPage.OnNavigatedTo");
	}
	
	protected override void OnAppearing()
	{
		base.OnAppearing();
		
		Console.WriteLine("MainPage.OnAppearing");
	}
}

