using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;


namespace WebAPI.Reporsitory
{
    public class UserRepository:IUserRepository
    {
        public List<User> GetUser()
        {
            List<User> user = new List<User>();

            using (var db = new APIDBContext())
            {

                user = db.user.ToList();
            }

            return user;
        }

        public List<User> GetUserProc()
        {
            List<User> user = new List<User>();

            using (var db = new APIDBContext())
            {

                user = db.user.FromSql("EXECUTE dbo.GetUsers").ToList();


            }


            return (user);
        }

        public List<UserProject> GetUserProject()
        {
            List<UserProject> user_project = new List<UserProject>();

            using (var db = new APIDBContext())
            {

                user_project = db.userProject.FromSql("EXECUTE dbo.GetUserProject").ToList();
            }


            return (user_project); ;
        }

    }
}


        
