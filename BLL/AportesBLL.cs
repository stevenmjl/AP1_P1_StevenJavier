using Microsoft.EntityFrameworkCore;
using AP1_P1_StevenJavier.DAL;
using AP1_P1_StevenJavier.Models;

namespace AP1_P1_StevenJavier.BLL
{
    public class AportesBLL
    {
        private Contexto _contexto;

        public AportesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int aportesId)
        {
            return _contexto.Aportes.Any(o => o.AportesId == aportesId);
        }

        private bool Insertar(Aportes aportes)
        {
            _contexto.Aportes.Add(aportes);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(Aportes aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }

        public bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AportesId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }

        public bool Eliminar(Aportes aportes)
        {
            _contexto.Entry(aportes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Aportes Buscar(string persona)
        {
            return _contexto.Aportes
                    .Where(o => o.Persona == persona)
                    .AsNoTracking()
                    .SingleOrDefault();
        }
    }
}