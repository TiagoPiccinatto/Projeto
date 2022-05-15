using Microsoft.AspNetCore.Mvc;
using NovoProjeto.Models;

namespace NovoProjeto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   
    public EventoController()
    {
    }
    public IEnumerable<Evento> _evento = new Evento []{
      new Evento() {
        EventoId = 1,
        Tema = "Angular .net-core",
        Local = "Sorocaba",
        QtdPessoas = 200,
        DataEvento = DateTime.Now.AddDays(2).ToString(),
        Lote = "1 lote",
        Imagemaurl = "Foto1.jpg"
       
      },
      new Evento() {
        EventoId = 2,
        Tema = "React.js",
        Local = "Votorantim",
        QtdPessoas = 400,
        DataEvento = DateTime.Now.AddDays(30).ToString(),
        Lote = "1 lote",
        Imagemaurl = "Foto.jpg"
       
      }
    };





    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return _evento;
    }

    
    [HttpGet ("{id}")]
    public IEnumerable<Evento> Getporid(int id)
    {
      return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post(){
      return "cara";
    }
}
