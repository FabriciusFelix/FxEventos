using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _eventos = new Evento[]{
          
              new Evento(){
               EventoId = 1,
               Tema = "Angular e .NEt 5",
               Local = "Belo Horizonte",
               DataEvento = DateTime.Now.AddDays(5),
               QtdPessoas = 30,
               Lote = "1º Lote=",
               ImagemURL= ("C:/Users/fdfelix/source/repos/ProEventos/Imagem1.jpg")
           },
           new Evento(){
               EventoId = 2,
               Tema = "Angular e SUAS NOVIDADES",
               Local = "São Paulo",
               DataEvento = DateTime.Now.AddDays(2),
               QtdPessoas = 250,
               Lote = "2º Lote=",
               ImagemURL= ("C:/Users/fdfelix/source/repos/ProEventos/Imagem2.jpg")
           },  
                    new Evento(){
               EventoId = 3,
               Tema = ".Net full",
               Local = "Rio de Janeiro",
               DataEvento = DateTime.Now.AddDays(2),
               QtdPessoas = 300,
               Lote = "1º Lote=",
               ImagemURL= ("C:/Users/fdfelix/source/repos/ProEventos/Imagem3.jpg")
           }
           
           
           };
      

        private readonly ILogger<EventoController> _logger;


        // public IEnumerable<Evento> eventos(_eventos){

          //this.eventos = _eventos
        // }
         
         
        public EventoController()
        {
           
        }
      
        

        [HttpGet]
        public IEnumerable<Evento> get(){
           
         return _eventos;
          }


         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
           
         return _eventos.Where(x => x.EventoId == id);
          }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de post";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }

}