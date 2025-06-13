using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Infraestrura.Arquivos.Compartilhado;
using ControleDeBar.Infraestrutura.Arquivos.ModuloMesa;
using ControleDeBar.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeBar.WebApp.Controllers
{
    [Route("Mesas")]
    public class MesaController : Controller
    {
        private readonly ContextoDados contextoDados;
        private readonly IRepositorioMesa repositorioMesa;

        public MesaController()
        {
            contextoDados = new ContextoDados(true);
            repositorioMesa = new RepositorioMesaEmArquivo(contextoDados);
        }

        [HttpGet]
       public IActionResult Index()
        {
            var registro = repositorioMesa.SelecionarRegistros();
            var visualizarVm = new VisualizarMesasViewModel(registro);
            return View(visualizarVm);
        }
    }
}
