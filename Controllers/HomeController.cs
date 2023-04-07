using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instâncias do tipo cliente
        Clientes cliente1 = new Clientes(01, "Arthur Ferreira", "857.032.950-41", "Arthur@gmail.com", "Madruga");
        Clientes cliente2 = new Clientes(02, "Willian Gates", "039.618.250-09", "Willian@gmail.com", "Bug");
        Clientes cliente3 = new Clientes(03, "Ada Lovelace", "800.777.250-50", "Ada@gmail.com", "Byron");
        Clientes cliente4 = new Clientes(04, "Linus Torvalds", "933.622.400-03", "Linus@gmail.com", "Pinguim");

        //lista de clientes
        List<Clientes> listaCliente = new List<Clientes>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);

        ViewBag.listaCliente = listaCliente;

        //instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A ", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Atl Dog", "15.836.689/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");

        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);

        ViewBag.listaFornecedores = listaFornecedores;

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
