namespace KSS.HorseRacing.Infrastucture.DataAccess.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using KSS.HorseRacing.Infrastucture.DataAccess.Interfaces;
    using KSS.HorseRacing.Infrastucture.DataModels;

    public class JockeyRepository : BaseRepository, IJockeyRepository
    {
        public IEnumerable<Jockey> GetAllJockeys()
        {
            var jockeys = getContext().Jockeys.ToList();
            return jockeys;
        }

        public Jockey Get(int id)
        {
            var jockey = getContext().Jockeys.FirstOrDefault(x => x.Id == id);
            return jockey;
        }

        public void Save(Jockey jockey)
        {
            jockey.IsActive = true;
            save(jockey);
        }

        public void Delete(Jockey jockey)
        {
            jockey.IsActive = false;
            save(jockey);
        }
    }
}