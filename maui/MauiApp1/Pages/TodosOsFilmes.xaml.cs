
using MauiApp1.Models;
using Newtonsoft.Json;


namespace MauiApp1;

public partial class TodosOsFilmes : ContentPage
{
    VerticalStackLayout verticalLayout = new VerticalStackLayout();
    ScrollView scrollView = new ScrollView();
    Label titulo = new Label();
    Button buttonExcluir;
    Button buttonAtualizar;
    public TodosOsFilmes()
	{

        titulo.Text = "Todos os filmes";
        titulo.VerticalOptions = LayoutOptions.Center;
        titulo.HorizontalOptions = LayoutOptions.Center;
        titulo.FontSize = 22;
        titulo.Padding = 50;
        verticalLayout.Children.Add(titulo);
        scrollView.Content = verticalLayout;
        InitializeComponent();
        ListaFilme();
        this.Content = scrollView;
    }
         
    private async void ListaFilme()
    {
        var filmes = await Buscar();
       

         foreach (var item in filmes)
        {

            Label labelNome = new Label();
            Label labelDuracao = new Label();
            Label labelGenero = new Label();
            HorizontalStackLayout horizontalLayout = new HorizontalStackLayout();
            buttonExcluir = new Button();
            buttonAtualizar = new Button();
            labelNome.Text = $"Nome: {item.Nome}";
            labelDuracao.Text = $"Duração: {item.Duracao}";
            labelGenero.Text = $"Genêro: {item.Genero}";
            labelNome.FontSize = 20;
            labelNome.Padding = 10;
            labelDuracao.FontSize = 20;
            labelDuracao.Padding = 10;
            labelGenero.FontSize = 20;
            labelGenero.Padding = 10;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.Clicked += AtualizarFilme;
            buttonAtualizar.CommandParameter = item.Id;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.Clicked += DeletarFilme;
            buttonExcluir.CommandParameter = item.Id;
            horizontalLayout.HorizontalOptions = LayoutOptions.Center;
            horizontalLayout.Children.Add(labelNome);
            horizontalLayout.Children.Add(labelDuracao);
            horizontalLayout.Children.Add(labelGenero);
            horizontalLayout.Children.Add(buttonAtualizar);
            horizontalLayout.Children.Add(buttonExcluir);
            verticalLayout.Children.Add(horizontalLayout);
        }
    }
    private async void AtualizarFilme(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new AtualizarFilme(buttonAtualizar.CommandParameter.ToString()));
    }
    private async void DeletarFilme(object sender,EventArgs args)
    {
        HttpClient client = new HttpClient();
        var urlBase = "https://localhost:7241/Api/Filme/RemoveFilme";
        var id = buttonExcluir.CommandParameter.ToString();
        var url = $"{urlBase}?Id={id}";
        HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, url);

        await client.SendAsync(message);
        await Navigation.PushAsync(new TodosOsFilmes());
    }
	private async Task<List<Filme>> Buscar()
	{
        var baseUrl = "https://localhost:7241/Api/Filme/AllFilmes";
        var client = new HttpClient(); 
        var result = await client.GetStringAsync(baseUrl);
        var filme = JsonConvert.DeserializeObject<List<Filme>>(result); 
        return filme;
      
    }
}