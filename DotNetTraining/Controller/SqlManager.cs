using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace DotNetTraining.Controller
{
   static  class SqlManager
    {
        static public  string InsertProfile = "INSERT INTO DataBase(ProfileName,Login,Password,Service)" +
                                               " VALUES(@profileName,@login,@password,@service)";

        static public string InsertService = "INSERT INTO Services(ServiceName) VALUES(@serviceName)";

        static public string UpdateServices = "SELECT ServiceName FROM Services ";
    }
}
