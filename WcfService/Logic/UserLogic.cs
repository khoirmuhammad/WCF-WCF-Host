using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Data;
using WcfService.Models;

namespace WcfService.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserData _data;
        public UserLogic()
        {
            _data = new UserData();
        }
        public Message<Guid> DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Message<UserModel> GetUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Message<Guid> SaveUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public Message<List<UserModel>> SelectUsers()
        {
            Message<List<UserModel>> result = new Message<List<UserModel>>();

            try
            {
                List<UserModel> users = new List<UserModel>();

                var response = _data.SelectUsers();

                result.IsSucceed = response.IsSucceed;
                result.Message = response.Message;

                foreach(var item in response.Data)
                {
                    users.Add(new UserModel
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Email = item.Email,
                        Phone = item.Phone,
                        Birthdate = item.Birthdate
                    });
                }

                result.Data = users;
            }
            catch(Exception ex)
            {
                result.IsSucceed = false;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}