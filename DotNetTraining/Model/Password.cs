using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining.Model
{
    sealed class Password
    {
        private string password { get; set; }

        public void SetPassword(string _temp)
        {
            password = _temp;
        }
        public string GetPassword()
        {
            return password;
        }
        public void NullPass()
        {
            password = null;
        }
        public bool IsRight()
        {
            string s = Model.Crypt.CreateMD5(password);
            

            return s == Controller.ReadWrite.read().Trim();

        }
    }
}
