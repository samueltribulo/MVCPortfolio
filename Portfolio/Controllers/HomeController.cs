using Microsoft.AspNetCore.Mvc;
using Portfolio.Interfaces;
using Portfolio.Models;
using Portfolio.Servicios;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IRepositorioCertificados repositorioCertificados;
        private readonly IServicioEmail servicioEmail;


        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IRepositorioCertificados repositorioCertificados, IServicioEmail servicioEmail)
        {
            this.repositorioCertificados = repositorioCertificados;
            this.servicioEmail = servicioEmail;
            this.repositorioProyectos = repositorioProyectos;

            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var certificados = repositorioCertificados.ObtenerCertificados();
            var modelo = new HomeIndexViewModel() { 
                Certificados= certificados,
            };

            return View(modelo);
        }

        [HttpGet]
        public IActionResult Proyectos()
        {

            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);

        }
        [HttpGet]
        public IActionResult Contacto()
        {

            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Contacto(ContactoDTO contacto)
        {
            _logger.LogError($"{contacto.Nombre}");
            _logger.LogError($"{contacto.Email}");
            _logger.LogError($"{contacto.Mensaje}");

            await servicioEmail.Enviar(contacto);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}