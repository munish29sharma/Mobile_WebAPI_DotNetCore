using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Reporsitory
{
    public interface IUserRepository
    {
        List <User> GetUser();
        List<UserProject> GetUserProject();

        List<User> GetUserProc();
    }
}
