using Eventos.BLL.Interface;
using Eventos.DAL;
using Eventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BLL.Implementation
{
    public class EventoBLL : IEventoBLL
    {
        public void Post(Evento evento)
        {
            EventosDAL dal = new EventosDAL();
            dal.Post(evento);
        }

        public void Put(Evento evento)
        {
            EventosDAL dal = new EventosDAL();
            dal.Put(evento);
        }

        public void Delete(Evento evento)
        {
            EventosDAL dal = new EventosDAL();
            dal.Delete(evento);
        }

        public Evento Get(int id)
        {
            EventosDAL dal = new EventosDAL();
            var evento = dal.Get(id);
            return evento;
        }

        public List<Evento> GetAll()
        {
            EventosDAL dal = new EventosDAL();
            var eventos = dal.GetAll();
            return eventos;
        }
    }
}