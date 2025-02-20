using instafram.Models;
using instafram.DAL;

namespace instafram.BLL {
    public class DmService {
        private readonly DmRepository _dmRepository;

        public DmService(DmRepository dmRepository) {
            _dmRepository = dmRepository;
        }

        public List<Dm> GetDms() {
            return _dmRepository.GetDms();
        }

        public Dm GetDm(int id) {
            return _dmRepository.GetDmById(id);
        }

        public Dm UpdateDm(Dm dm) {
            return _dmRepository.UpdateDm(dm);
        }

        public void DeleteDm(Dm dm) {
            _dmRepository.DeleteDm(dm);
        }

        public Dm CreateDm(Dm dm) {
            return _dmRepository.CreateDm(dm);
        }
    }
}
