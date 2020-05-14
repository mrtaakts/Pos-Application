using System.Linq;

namespace POS.Models {
    public interface IUserRepository {

        IQueryable<User> Users { get; }
        void CreateUser (User user);

    }
}