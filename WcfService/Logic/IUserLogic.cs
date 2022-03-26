using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Models;
using WcfService.Data;

namespace WcfService.Logic
{
    public interface IUserLogic
    {
        Message<List<UserModel>> SelectUsers();
        Message<UserModel> GetUser(Guid userId);
        Message<Guid> SaveUser(UserModel userModel);
        Message<Guid> DeleteUser(Guid userId);
    }
}