using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Data
{
    public class UserData : IUserData
    {
        private readonly ServiceEntities _contex;
        public UserData()
        {
            _contex = new ServiceEntities();
        }
        public Message<Guid?> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Message<Guid> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public Message<User> GetUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Message<List<User>> SelectUsers()
        {
            Message<List<User>> result = new Message<List<User>>();

            try
            {
                var data = _contex.Users.ToList();

                result.IsSucceed = true;
                result.Data = data;
            }
            catch(Exception ex)
            {
                result.IsSucceed = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public Message<Guid> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}