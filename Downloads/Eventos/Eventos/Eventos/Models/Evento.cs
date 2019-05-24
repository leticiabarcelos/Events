using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string NomeEvento { get; set; }
        public int QuantidadeEntradas { get; set; }
        public double ValorIngresso { get; set; }
        public DateTime DataEvento { get; set; }
    }
}
