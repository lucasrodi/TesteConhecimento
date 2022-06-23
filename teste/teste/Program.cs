using teste.Models;
using teste.Services;
using teste.Services.Iservices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IBuscarEmpresaPorNome, BuscarEmpresaPorNome>();
builder.Services.AddTransient<ICadastrarFornecedorComCnpj, CadastrarFornecedorComCnpj>();
builder.Services.AddTransient<ICadastrarFornecedorComCpf, CadastrarFornecedorComCpf>();
builder.Services.AddTransient<ICadastrarVarioTelefones, CadastrarVarioTelefones>();
builder.Services.AddTransient<IListarEmpresas, ListarEmpresas>();
builder.Services.AddTransient<IListarFornecedor<FornecedorComCpf>, ListarFornecedorComCpf>();
builder.Services.AddTransient<IListarFornecedor<FornecedorComCnpj>, ListarFornecedorComCnpj>();
builder.Services.AddTransient<ICadastraEmpresa, CadastraEmpresa>();
builder.Services.AddTransient<IBuscarEmpresaPorNomeLista<List<Empresa>>, BuscarEmpresaPorNomeLista>();
builder.Services.AddTransient<IBuscarFornecedores<FornecedorComCpf>,BuscarFornecedoresComCpf>();
builder.Services.AddTransient<IBuscarFornecedores<FornecedorComCnpj>, BuscarFornecedoresComCnpj>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
