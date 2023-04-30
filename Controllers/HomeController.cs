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
        // instancias do tipo cliente
       Cliente cliente1 = new Cliente(02, "Gabriel Germano", "857.032.950-41","ggermanow279@gmail.com","Robson");    
        
        //lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);

        ViewBag.listaClientes = listaClientes;
        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A","14.182.102/0001-80", "c-sharp@pet.org");
        
        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
       
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
