using Microsoft.AspNetCore.Mvc;

namespace TpSeries.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries=BD.ListarSeries();
        return View();
    }
    public List<Temporadas> ListarTemporadas(int IdSerie){
        return BD.ListarTemporadas(IdSerie);
    }
    public List<Actores> ListarActores(int IdSerie){
        return BD.ListarActores(IdSerie);
    }
    public string GetSinopsis(int IdSerie){
        return BD.GetSinopsis(IdSerie);
    }
}
