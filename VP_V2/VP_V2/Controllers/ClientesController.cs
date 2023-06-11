using Microsoft.AspNetCore.Mvc;
using VP_V2.Data;
using VP_V2.Models;
using VP_V2.Models.ModelsView;

namespace VP_V2.Controllers
{
    public class ClientesController : Controller
    {
        private readonly VP_DBcontext vPcontext;

        public ClientesController(VP_DBcontext VPcontext)
        {
            vPcontext = VPcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCliente addCliente)
        {
            var cliente = new Cliente()
            {
                Nom = addCliente.Nom,
                Ape = addCliente.Ape,
                Dni = addCliente.Dni,
                Cod_Tel = addCliente.Cod_Tel,
                Tel = addCliente.Tel,
                Mail = addCliente.Mail
            };

            vPcontext.Clientes.Add(cliente);
            vPcontext.SaveChanges();

            return RedirectToAction("Add");

        }













    }
}
