using assignment2_crud.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }

}

