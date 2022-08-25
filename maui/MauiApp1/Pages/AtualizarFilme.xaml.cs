using System.Net.Http.Json;

namespace MauiApp1;

public partial class AtualizarFilme : ContentPage
{
	private string id;
	public AtualizarFilme(string id)
	{
		InitializeComponent();
		this.id = id;
	}
	private async void Atualiza(object sender,EventArgs args)
	{
		try
		{
            var baseUrl = "https://localhost:7241/Api/Filme/UpdateFilme";
            var url = $"{baseUrl}?Id={id}&Nome={nomeFilme.Text}&Duracao={duracaoFilme.Text}&Genero={generoFilme.Text}";
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Put, url);
            await client.SendAsync(message);
            await Navigation.PushAsync(new TodosOsFilmes());

        }
		catch (Exception)
		{
			await DisplayAlert("Erro", "Não conseguimos Atualizar o Filme", "OK");
		}
		
    }
}