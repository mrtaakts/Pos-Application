using System.Linq;

namespace POS.Models {
    public class EfUserRepository : IUserRepository {
        private ApplicationDbContext _context;
        public EfUserRepository (ApplicationDbContext context) {
            _context = context;
        }

        public IQueryable<User> Users => _context.Users;

        public void CreateUser (User user) {
            _context.Users.Add (user); // isaretleme
            _context.SaveChanges (); // gerceklesme yeri
        }

    }
}