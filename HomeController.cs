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
        //Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III","985.889.642-98","bilijoe@yahoo.com", "Chico");

        //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);

        ViewBag.ListaClientes = listaClientes;


        //Instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.213.321/0001-98","C#@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "12.231.542/0001-98","ConsoleTraceListener@atlt.dog.br");

        //lista de fornecedores
        List<Fornecedor> listafornecedores = new List<Fornecedor>();
        listafornecedores.Add(fornecedor1);
        listafornecedores.Add(fornecedor2);

        ViewBag.listaFornecedores = listafornecedores;

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
