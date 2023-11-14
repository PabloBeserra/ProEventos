using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

        public EventosController(Datacontext context)
        {
            this.context = context;
          
        }

            public IEnumerable<Evento> _evento =  new Evento[]{
                new Evento(){
                EventoId = 1,
                Tema="Angular",
                Local="belo horizonte",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyyy"),
                ImagemURL = "foto.png"
                },
                 new Evento(){
                EventoId = 2,
                Tema="Angular e susas novidades",
                Local="são paulo",
                Lote = "2 lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyyy"),
                ImagemURL = "foto2.png"}
            };
        private readonly Datacontext context;

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return context.Eventos;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
        {
           return context.Eventos.Where(evento => evento.EventoId == id);
        }

          [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";           
        }

            [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Exemplo de Put com id = {id}";           
        }

              [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";           
        }
    
    
    }
}
