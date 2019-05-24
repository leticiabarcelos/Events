using Eventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.DAL
{
    public class EventosDAL
    {
        public List<Evento> pc = new List<Evento>();
        public void Post(Evento evento)
        {
            using (Context context = new Context())
            {
                context.Evento.Add(evento);
                context.SaveChanges();
            }
        }

        public void Put(Evento evento)
        {
            using (Context context = new Context())
            {
                context.Evento.Update(evento);
                context.SaveChanges();
            }
        }

        public void Delete(Evento evento)
        {
            using (Context context = new Context())
            {
                context.Evento.Remove(evento);
                context.SaveChanges();
            }
        }

        public Evento Get(int id)
        {
            using (Context context = new Context())
            {
                Evento evento = new Evento();
                evento = context.Evento.Find(id);
                return evento;
            }
        }

        public List<Evento> GetAll()
        {
            using (Context context = new Context())
            {
                List<Evento> evento = new List<Evento>();
                evento = context.Evento.ToList();
                return evento;
            }
        }
    }
}