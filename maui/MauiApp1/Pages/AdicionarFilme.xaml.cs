
using MauiApp1.Services;

namespace MauiApp1;

public partial class AdicionarFilme : ContentPage
{
    public AdicionarFilme()
    {
        InitializeComponent();
    }
   
    private async void Enviar(object sender, EventArgs args)
    {
        if (VerificaInputVazio.VerificarNull(Nome.Text) == false||
            VerificaInputVazio.VerificarNull(Duracao.Text) == false ||
            VerificaInputVazio.VerificarNull(Genero.Text) == false )
        {
            await DisplayAlert("Erro", "Você precisa preencher o nome, duração, genêro para poder adiciona-lo", "ok");

        }
        try
        {
            var baseUrl = "https://localhost:7241/Api/Filme/AddFilme";
            var client = new HttpClient();
            var url = $"{baseUrl}?Nome={Nome.Text}&Duracao={Duracao.Text}&Genero={Genero.Text}";
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, url);
            await client.SendAsync(message);
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception)
        {
            await DisplayAlert("Erro", "Não foi possivel adicionar o filme", "ok");
        }

    }
}





