using Microsoft.AspNetCore.Mvc;
using teste.Data;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Controllers
{
    public class FornecedorController : Controller
    {
        IBuscarEmpresaPorNome empresaPorNome ;
        IListarEmpresas empresas ;
        ICadastrarVarioTelefones telefones ;
        ICadastrarFornecedorComCnpj cadastrarFornecedorComCnpj ;
        ICadastrarFornecedorComCpf cadastrarFornecedorComCpf ;
        IListarFornecedor<FornecedorComCpf> listaDeFornecedoresCpf;
        IListarFornecedor<FornecedorComCnpj> listaDeFornecedoresCnpj;

        public FornecedorController(
            IBuscarEmpresaPorNome empresaPorNome,
            IListarEmpresas empresas,
            ICadastrarVarioTelefones telefones,
            ICadastrarFornecedorComCnpj cadastrarFornecedorComCnpj,
            ICadastrarFornecedorComCpf cadastrarFornecedorComCpf,
            IListarFornecedor<FornecedorComCpf> listaDeFornecedoresCpf,
            IListarFornecedor<FornecedorComCnpj> listaDeFornecedoresCnpj)
        {
            this.empresaPorNome = empresaPorNome;
            this.empresas = empresas;
            this.telefones = telefones;
            this.cadastrarFornecedorComCnpj = cadastrarFornecedorComCnpj;
            this.cadastrarFornecedorComCpf = cadastrarFornecedorComCpf;
            this.listaDeFornecedoresCpf = listaDeFornecedoresCpf;
            this.listaDeFornecedoresCnpj = listaDeFornecedoresCnpj;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Cadastro)
        {
            if (Cadastro == "Cpf")
            {
              return RedirectToAction("FornecedorComCpf");
            }
         return   RedirectToAction("FornecedorComCnpj");
        }
        public IActionResult FornecedorComCpf()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FornecedorComCpf(string Cpf)
        {
            var fornecedor = listaDeFornecedoresCpf.Listar(Cpf);
            if(fornecedor == null)
            {
              return  RedirectToAction("Error");
            }
            return View(fornecedor);
        }
        public IActionResult FornecedorComCnpj()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FornecedorComCnpj(string Cnpj)
        {
            var fornecedor = listaDeFornecedoresCnpj.Listar(Cnpj);
            if (fornecedor == null)
            {
                return RedirectToAction("Error");
            }
            return View(fornecedor);
        }
        public IActionResult Cadastrar(string Cadastro)
        {
            if (Cadastro == "Cpf")
            {
            return RedirectToAction("CadastrarComCpf");
            }
            return RedirectToAction("CadastrarComCnpj");
        }
        public IActionResult CadastrarComCpf()
        {
            var ListaEmpresa = empresas.Listar();
            return View(ListaEmpresa);
        }
        public IActionResult CadastrarComCnpj()
        {
            var ListaEmpresa = empresas.Listar();
            return View(ListaEmpresa);
        }
        [HttpPost]
        public IActionResult CadastrarComCnpj(string Cnpj, string NomeFornecedor,string Nome,
          string Telefone ,string Telefone2 ,string Telefone3, string Telefone4)
        {       
            var NomeEmpresa = empresaPorNome.NomeEmpresa(Nome);
            
                int[] arrayDeTelefones = telefones.Cadastrar(Telefone, Telefone2, Telefone3, Telefone4);
                var telefone1 = arrayDeTelefones[0];
                var telefone2 = arrayDeTelefones[1];
                var telefone3 = arrayDeTelefones[2];
                var telefone4 = arrayDeTelefones[3];
                cadastrarFornecedorComCnpj.Cadastrar(Cnpj, NomeEmpresa,
                   NomeFornecedor, DateTime.Now, telefone1, telefone2, telefone3, telefone4);
                return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult CadastrarComCpf(string Cpf, string Rg, string DataNascimento, string NomeFornecedor, string Nome,
         string Telefone, string Telefone2, string Telefone3, string Telefone4)
        { 
            var NomeEmpresa = empresaPorNome.NomeEmpresa(Nome);

            DateTime DataNascimentoConvertida = Convert.ToDateTime(DataNascimento);
            var anoAtual = DateTime.Now;
            
            if (DataNascimentoConvertida.AddYears(18) < anoAtual)
            {
                int[] arrayDeTelefones = telefones.Cadastrar(Telefone, Telefone2, Telefone3, Telefone4);
                var telefone1 = arrayDeTelefones[0];
                var telefone2 = arrayDeTelefones[1];
                var telefone3 = arrayDeTelefones[2];
                var telefone4 = arrayDeTelefones[3];
                cadastrarFornecedorComCpf.Cadastrar(Cpf, Rg, DataNascimentoConvertida, NomeEmpresa,
                  NomeFornecedor, DateTime.Now, telefone1, telefone2, telefone3, telefone4);
                 return RedirectToAction("Index");
                
            }
            return RedirectToAction("MenorDeIdade");


        }
        public IActionResult MenorDeIdade()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
