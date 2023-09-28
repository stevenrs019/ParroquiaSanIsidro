using Microsoft.AspNetCore.Mvc;
using SistemaWebParroquia.Models;
using SistemaWebParroquia.Service;

namespace SistemaWebParroquia.Controllers
{
    public class CosmosController : Controller
    {
        ServiceCosmosDb service;
        public CosmosController(ServiceCosmosDb service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(String accion)
        {
            await this.service.CrearBbddPersonaAsync();
            await this.service.CrearColeccionPersonasAsync();
            List<Persona> persona = this.service.CrearPersona();
            foreach (Persona v in persona)
            {
                await this.service.InsertarPersona(v);
            }
            ViewBag.mensaje = "CREADO";
            return View();
        }
        public IActionResult ListPersonas()
        {
            return View(this.service.GetPersonas());
        }
        public async Task<IActionResult> Detalles(String id)
        {
            return View(await this.service.FindPersonaAsyn(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Persona persona)
        {
            await this.service.InsertarPersona(persona);
            return RedirectToAction("ListPersonas");
        }
        public async Task<IActionResult> Delete(String id)
        {
            await this.service.EliminarPersona(id);
            return RedirectToAction("ListPersonas");
        }
        public async Task<IActionResult> Editar(String id)
        {
            return View(await this.service.FindPersonaAsyn(id));
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Persona persona)
        {
            await this.service.ModificarPersona(persona);
            return RedirectToAction("ListPersonas");
        }


    }
}
