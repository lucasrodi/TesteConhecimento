using Microsoft.AspNetCore.Mvc;
using teste.Models;
using teste.Services.Iservices;

namespace teste.Controllers
{
    public class EmpresaController : Controller
    {
        ICadastraEmpresa empresa;
        IBuscarEmpresaPorNomeLista<List<Empresa>> buscarEmpresaPorNome;
        IBuscarFornecedores<FornecedorComCpf> buscarFornecedoresCpf;
        IBuscarFornecedores<FornecedorComCnpj> buscarFornecedoresCnpj;

        public EmpresaController(ICadastraEmpresa empresa,
            IBuscarEmpresaPorNomeLista<List<Empresa>> buscarEmpresaPorNome,
           IBuscarFornecedores<FornecedorComCpf> buscarFornecedoresCpf, IBuscarFornecedores<FornecedorComCnpj> buscarFornecedoresCnpj)
        {
            this.empresa = empresa;
            this.buscarEmpresaPorNome = buscarEmpresaPorNome;
            this.buscarFornecedoresCpf = buscarFornecedoresCpf;
            this.buscarFornecedoresCnpj = buscarFornecedoresCnpj;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Empresa)
        {
           var EmpresaLista= buscarEmpresaPorNome.Buscar(Empresa);
            return View(EmpresaLista);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(string Cnpj, string Nome , string Uf)
        {
            empresa.Cadastrar(Cnpj, Nome, Uf);  
            return RedirectToAction("Index");
        }
        public IActionResult Fornecedores(string Fornecedores)
        {
            if (Fornecedores=="Cpf")
            {
              return  RedirectToAction("FornecedoresComCpf");
            }
            return RedirectToAction("FornecedoresComCnpj");
        }
        
        public IActionResult FornecedoresComCpf()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FornecedoresComCpf(string Cpf)
        {
            var fornecedor = buscarFornecedoresCpf.BuscarFornecedor(Cpf);
            return View(fornecedor);
        }
        [HttpPost]
        public IActionResult FornecedoresComCnpj(string Cnpj)
        {
            var fornecedorComCnpj = buscarFornecedoresCnpj.BuscarFornecedor(Cnpj);
            return View(fornecedorComCnpj);
        }
        public IActionResult FornecedoresComCnpj()
        {
         
            return View();
        }
    }
}
