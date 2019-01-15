using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining.Model
{
    public class Transporter
    {
        public string ProfileName { get; set; }
        public string ProfileLogin { get; set; }
        public string ProfilePassword { get; set; }
        public Transporter()
        { }

        public override string ToString()
        {
            return string.Format("{0}--{1}--{2}", ProfileName, ProfileLogin, ProfilePassword);
        }
        public static void AddTransporterData(string _ProfileName, string _ProfileLogin, string _ProfilePassword, Transporter _t)
        {
            _t.ProfileName = _ProfileName;
            _t.ProfileLogin = _ProfileLogin;
            _t.ProfilePassword = _ProfilePassword;
        }
    }
}
