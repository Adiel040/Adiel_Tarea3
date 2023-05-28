using DAL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BLL
{
    public class TicketsBLL
    {
        private Contexto _contexto;

        public TicketsBLL(Contexto contexto)
        {
            this._contexto = contexto;
        }
        private bool Existe(int id)
        {
            return _contexto.Tickets.Any(t => t.TicketId == id);
        }
        private bool Insertar(Tickets ticket)
        {
            _contexto.Tickets.Add(ticket);

            return _contexto.SaveChanges() > 0;
        }
        private bool Modificar(Tickets ticket)
        {
            _contexto.Entry(ticket).State = EntityState.Modified;

            return _contexto.SaveChanges() > 0;
        }
        public bool Guardar(Tickets ticket)
        {
            if (Existe(ticket.TicketId))
            {
                return Modificar(ticket);
            }
            else
            {
                return Insertar(ticket);
            }
        }

        public Tickets? Buscar(int Id)
        {
            return _contexto.Tickets.Find(Id);
        }
        public List<Tickets> ObtenerLista()
        {
            return _contexto.Tickets.ToList();
        }

        public bool Eliminar(int id)
        {
            var ticket = _contexto.Tickets.Find(id);
            if(ticket == null)
            {
                return false;
            }
            _contexto.Tickets.Remove(ticket);
            return _contexto.SaveChanges() > 0;
        }
    }
}