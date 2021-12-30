using DIO.Series.Interfaces;

namespace DIO.Series.Repositories
{
    public class SerieRepository : IRepository<Series>
    {
        private List<Series> ListSeries = new List<Series>();


        public List<Series> GetAll()
        {
            return ListSeries;
        }

        public Series GetById(int id)
        {
            return ListSeries[id];
        }

        public void Insert(Series entity)
        {
            ListSeries.Add(entity);
        }
        public void Delete(int id)
        {
            ListSeries[id].ToDelete();
        }

        public int NextId()
        {
            return ListSeries.Count;
        }

        public void Update(int id, Series entity)
        {
            ListSeries[id] = entity;
        }
    }
}