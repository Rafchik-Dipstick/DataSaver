using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DotNetTraining.Controller
{
    class ChangeLog
    {
        //static string added_service = "Added service with a name - ";
        //static string begin_Profile = "Aded Profile - ";
        //static string changed_Profile = "Changed Profile - ";
        //static string after_ProfileName = " - in DataBase with a login -";
        //static string begin = "\r\n******";
        //static string end = " .******\r\n";
        //static string ProfileDeleted = "Profiles have been Deleted";
        //static string ServicesDeleted = "Services have been Deleted";

        public static void AddProfile(string name, string login)
        {
            using (var fstream = new StreamWriter("changelog.txt", true))
            {
                string result = "A new Profile '"+  name + "'with a  '" + login + "' login has been added." + "\r\n";
                fstream.WriteLine(result);

            }
        }
        public static void ChangeProfile(string name)
        {
            using (var fstream = new StreamWriter("changelog.txt", true))
            {
                string result = "Changed profile '"+ name + "'\r\n";
                fstream.WriteLine(result);
            }
        }
        public static void DeleteProfile()
        {
            using (var fstream = new StreamWriter("changelog.txt", true))
            {
                string result = "All Profiles were sucessfully deleted!"+ "\r\n";
                fstream.WriteLine(result);
            }
        }
        public static void DeletedServices()
        {
            using (var fstream = new StreamWriter("changelog.txt", true))
            {
                string result = "All Services were sucessfully deleted!" + "\r\n";
                fstream.WriteLine(result);
            }
        }
        public static void AddServices(string s)
        {
            using (var fstream = new StreamWriter("changelog.txt", true))
            {
                string result = "A new service'" + s + "' were added!" + "\r\n";
                fstream.WriteLine(result);
            }
        }
    }
}

