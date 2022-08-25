namespace MauiApp1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
       
    }
	private async void NavegarAdicionarFilme(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new AdicionarFilme());
	}
    private async void NavegarBuscarFilme(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new BuscarFilme());
    }
    private async void NavegarTodosFilmes(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new TodosOsFilmes());
    }

}

