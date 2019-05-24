using Eventos.BLL.Implementation;
using Eventos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Controllers
{
    [Route("api/[controller]")]
    public class EventoController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public EventoController() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evento"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]  Evento evento)
        {
            EventoBLL eventoBLL = new EventoBLL();
            eventoBLL.Post(evento);
            return Json(evento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evento"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Evento evento)
        {
            EventoBLL eventoBLL = new EventoBLL();
            eventoBLL.Put(evento);
            return Json(evento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="evento"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Evento evento)
        {
            EventoBLL eventoBLL = new EventoBLL();
            eventoBLL.Delete(evento);
            return NoContent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            EventoBLL eventoBLL = new EventoBLL();
            var evento = eventoBLL.Get(id);
            return Json(evento);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            EventoBLL eventoBLL = new EventoBLL();
            var get = eventoBLL.GetAll();
            return Json(get);
        }

        public class Eventos
        {
            public int id { get; set; }
            public string nomeEvento { get; set; }
            public int auantidadeEntradas { get; set; }
            public double valorIngresso { get; set; }
            public DateTime dataEvento { get; set; }
        }
    }
}