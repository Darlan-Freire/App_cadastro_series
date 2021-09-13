using System;
using System.Collections.Generic;

namespace app_cadastro
{
    public class SerieRepository : IRepository<Series>
    {
        public List<Series> listaSerie = new List<Series>();

        public void Delete(int id)
        {
            listaSerie[id].delete();
        }

        public void Insert(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public Series ReturnById(int id)
        {
            return listaSerie[id];
        }

        public void Update(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

    }
}
