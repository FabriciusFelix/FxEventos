﻿using System;
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
    [Route("/api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _eventos;


        private readonly ILogger<EventosController> _logger;


        // public IEnumerable<Evento> eventos(_eventos){

        //this.eventos = _eventos
        // }

        private readonly DataContext context;

        public EventosController(DataContext context)
        {
            this.context = context;

        }



        [HttpGet]
        public IEnumerable<Evento> get()
        {

            return context.Eventos;
        }


        [HttpGet("{id}")]
        public Evento GetById(int id)
        {

            return context.Eventos.First(x => x.EventoId == id);
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