using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DotNetTraining.Controller
{
    class CorrectData
    {
          public static bool StrIsNotNull(string _temp,string _temp1,string _temp2)
        {
            return _temp != "" && _temp1 != "" && _temp2 != "";
        }
        public static bool StrHasNoSpacebars(string _temp, string _temp1, string _temp2)
        {
            return !_temp.Contains(" ") && !_temp1.Contains(" ") && !_temp2.Contains(" ");
        }
        public static bool CbxSelectedItem(ComboBox _temp)
        {
            return _temp.SelectedIndex > -1;
        }

    }
}
