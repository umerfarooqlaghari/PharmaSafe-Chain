using ProjectLearn.Data;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels;

namespace ProjectLearn.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context) 
        {
            _context = context;
        }

        public ICollection<UserTable> GetUsers()
        {
            return _context.UserInformtionTable.OrderBy(p=> p.UserId).ToList();
        }

    }
}
