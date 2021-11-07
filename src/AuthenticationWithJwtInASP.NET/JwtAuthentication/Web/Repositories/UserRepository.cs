using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.Models;

namespace Web.Repositories
{
    public interface IUserRepository
    {

        UserEntity FetchUser(UserModel model);
    }
    public class UserRepository : IUserRepository
    {
        private List<UserEntity> Repository()
        {
            return new List<UserEntity> { 
                new UserEntity { UserName ="Daniel", Password ="dd007", Role  = "Manager"},
                new UserEntity { UserName ="Suresh", Password ="dd008", Role  = "TeamLead"},
                new UserEntity { UserName ="John", Password ="ddxx07", Role  = "User"}
            };
        }
        public UserEntity FetchUser(UserModel model)
        {
            return Repository().Where(x => x.UserName.ToLower() == model.UserName.ToLower()
            && x.Password == model.Password).FirstOrDefault();
        }
    }
}
