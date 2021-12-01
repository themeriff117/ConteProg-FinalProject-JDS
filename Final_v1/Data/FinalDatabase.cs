using Final_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1.Data
{
    public class FinalDatabase
    {
        private Finalcontext _context;
        public FinalDatabase(Finalcontext context)
        {
            _context = context;
        }
        public void AddVinyls(Vinyl vinylToAdd)
        {
            _context.VinylCollection.Add(vinylToAdd);
        }
        public IEnumerable<Vinyl> GetAllVinyls()
        {
            return _context.VinylCollection.ToList();
        }
        public void AddNewVinyl(Vinyl vinyl)
        {
            try
            {
                _context.VinylCollection.Add(vinyl);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Vinyl DeleteVinyl(string artist)
        {
            var vinylToDelete = _context.VinylCollection.First(x => x.Artist == artist);
            if(vinylToDelete != null)
            {
                _context.Remove(vinylToDelete);
                _context.SaveChanges();
            }
            return vinylToDelete;
        }
        public Vinyl UpdateVinylCollection(Vinyl vinyl)
        {
            var updateCollection = _context.VinylCollection.First(x => x.Artist == vinyl.Artist);
            if(updateCollection != null)
            {
                updateCollection.Artist = vinyl.Artist;
                updateCollection.Album = vinyl.Album;
                updateCollection.Year = vinyl.Year;
                _context.SaveChanges();
            }
            return updateCollection;
        }

        // follow above code (from line 16) for your tables,
        // used Prof's  https://github.com/dekokdj1/TestMvcProject/blob/main/TestMvcProject/Data/FootballTeamsDatabase.cs as guide
        // follow my controller as guide to update your controller
    }
}
