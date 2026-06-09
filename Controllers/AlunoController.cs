using Microsoft.AspNetCore.Mvc;

namespace _p_gina_com_ASP_NET_MVC.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Ana Souza";
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "3º semestre";

        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Id = id;
        ViewBag.Nome = "Ana Souza";

        return View();
    }
}