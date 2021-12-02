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
        //group table
        public IEnumerable<NameDatabase> GetById (int id)
        {
            if (id == 0)
            {
                return _context.Name.Take(5);
            }
            return _context.Name.Where(x => x.Id == id);
        }
        public void AddNameDatabase(NameDatabase nameDatabase)
        {
            _context.Name.Add(nameDatabase);
        }
        public IEnumerable<NameDatabase> GetNameDatabase()
        {
            return _context.Name.ToList();
        }
        public void AddNewNameDatabase(NameDatabase nameDatabase)
        {
            try
            {
                _context.Name.Add(nameDatabase);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public NameDatabase DeleteNameDatabase(string Name)
        {
            var nameToDelete = _context.Name.First(x => x.Name == Name);
            if (nameToDelete != null)
            {
                _context.Remove(nameToDelete);
                _context.SaveChanges();
            }
            return nameToDelete;
        }
        public NameDatabase UpdateNameDatabase(NameDatabase nameDatabase)
        {
            var updateCollection = _context.Name.First(x => x.Name == nameDatabase.Name);
            if (updateCollection != null)
            {
                updateCollection.Name = nameDatabase.Name;
                updateCollection.Bday = nameDatabase.Bday;
                updateCollection.CP = nameDatabase.CP;
                updateCollection.Year = nameDatabase.Year;
                _context.SaveChanges();
            }
            return updateCollection;
        }
        //dora's table
        public IEnumerable<Vinyl> GetByVinylId(int id)
        {
            if (id == 0)
            {
                return _context.VinylCollection.Take(5);
            }
            return _context.VinylCollection.Where(x => x.Id == id);
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
        // Sam
        public IEnumerable<Anime> GetByAnimeId(int id)
        {
            if (id == 0)
            {
                return _context.Anime.Take(5);
            }
            return _context.Anime.Where(x => x.Id == id);
        }
        public void AddAnime(Anime anime)
        {
            _context.Anime.Add(anime);
        }
        public IEnumerable<Anime> GetAnime()
        {
            return _context.Anime.ToList();
        }
        public void AddNewAnime(Anime anime)
        {
            try
            {
                _context.Anime.Add(anime);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Anime DeleteAnime(string Name)
        {
            var animenameToDelete = _context.Anime.First(x => x.Name == Name);
            if (animenameToDelete != null)
            {
                _context.Remove(animenameToDelete);
                _context.SaveChanges();
            }
            return animenameToDelete;
        }
        public Anime UpdateAnime(Anime anime)
        {
            var updateCollection = _context.Anime.First(x => x.Name == anime.Name);
            if (updateCollection != null)
            {
                updateCollection.Name = anime.Name;
                updateCollection.MainChara = anime.MainChara;
                updateCollection.Genre = anime.Genre;
                updateCollection.Description = anime.Description;
                _context.SaveChanges();
            }
            return updateCollection;
        }
        // Julia
        public IEnumerable<DnD> GetByDnDId(int id)
        {
            if (id == 0)
            {
                return _context.DnD.Take(5);
            }
            return _context.DnD.Where(x => x.Id == id);
        }
        public void AddDnD(DnD dnd)
        {
            _context.DnD.Add(dnd);
        }
        public IEnumerable<DnD> GetDnD()
        {
            return _context.DnD.ToList();
        }
        public void AddNewDnD(DnD dnd)
        {
            try
            {
                _context.DnD.Add(dnd);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DnD DeleteDnD(string Name)
        {
            var dndnameToDelete = _context.DnD.First(x => x.Name == Name);
            if (dndnameToDelete != null)
            {
                _context.Remove(dndnameToDelete);
                _context.SaveChanges();
            }
            return dndnameToDelete;
        }
        public DnD UpdateDnD(DnD dnd)
        {
            var updateCollection = _context.DnD.First(x => x.Name == dnd.Name);
            if (updateCollection != null)
            {
                updateCollection.Name = dnd.Name;
                updateCollection.Class= dnd.Class;
                updateCollection.Race= dnd.Race;
                updateCollection.Background = dnd.Background;
                _context.SaveChanges();
            }
            return updateCollection;
        }


    }
}
