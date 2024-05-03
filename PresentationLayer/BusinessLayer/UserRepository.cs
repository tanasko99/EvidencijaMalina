using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness
    {
        private readonly UserRepository userRepository;

        public UserBusiness()
        {
            this.userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return this.userRepository.GetAllUsers();
        }
    }

}