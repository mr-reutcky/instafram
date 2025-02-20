using instafram.Models;

namespace instafram.DAL {
    public class DmRepository {
        private readonly InstaframContext _context;

        public DmRepository(InstaframContext context) {
            _context = context;
        }

        public List<Dm> GetDms() {
            return _context.Dms.ToList();
        }

        public Dm GetDmById(int id) {
            return _context.Dms.Find(id);
        }

        public Dm UpdateDm(Dm dm) {
            _context.Dms.Update(dm);
            _context.SaveChanges();
            return dm;
        }

        public Dm CreateDm(Dm dm) {
            _context.Dms.Add(dm);
            _context.SaveChanges();
            return dm;
        }

        public Dm DeleteDm(Dm dm) {
            _context.Dms.Remove(dm);
            _context.SaveChanges();
            return dm;
        }
    }
}
