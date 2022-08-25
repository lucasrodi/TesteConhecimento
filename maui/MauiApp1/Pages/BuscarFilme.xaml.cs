
using MauiApp1.Models;
using MauiApp1.Services;
using Newtonsoft.Json;

namespace MauiApp1;

public partial class BuscarFilme : ContentPage
{
	public BuscarFilme()
	{
		InitializeComponent();
	}
	private async void Buscar(object sender, EventArgs args)
	{
		if (VerificaInputVazio.VerificarNull(FilmeId.Text) == false)
		{
			await DisplayAlert("Erro", "Você precisa de um id para buscar o filme", "Ok");
		}
		else
		{
            try
            {
                var result = await BuscarFilmePorId(FilmeId.Text);
                var filme = JsonConvert.DeserializeObject<Filme>(result);
                idFilme.Text = filme.Id.ToString();
                nomeFilme.Text = filme.Nome;
                duracaoFilme.Text = filme.Duracao;
                generoFilme.Text = filme.Genero;
            }
            catch (Exception)
            {

                await DisplayAlert("Erro", "Não conseguimos buscar o filme ", "Ok");
            }
        }
		
	}
	private async Task<string> BuscarFilmePorId(string id)
	{
        var baseUrl = "https://localhost:7241/Api/Filme/FilmeId";
        var client = new HttpClient();
        var url = $"{baseUrl}?Id={id}";
        var filme = await client.GetStringAsync(url);
		return filme;
    }
}