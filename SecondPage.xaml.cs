namespace _25371_repro;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }
    
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Console.WriteLine("SecondPage.OnNavigatedTo");
    }
    
    private void OnGoToMainPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void OnPopNavigationStackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
		
        Console.WriteLine("SecondPage.OnAppearing");
    }
}

