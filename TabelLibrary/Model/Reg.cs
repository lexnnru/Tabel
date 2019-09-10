using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TabelLibrary
{
    public class Reg
    {
        public void write(int triger)
        {
            RegistryKey currentuser = Registry.CurrentUser;
            RegistryKey software = currentuser.OpenSubKey("SOFTWARE", true);
            RegistryKey tabel = software.CreateSubKey("tabel");
            tabel.SetValue("triger", triger);
            tabel.Close();

        }
        public int reed()
        {
            RegistryKey currentuser = Registry.CurrentUser;
            RegistryKey software = currentuser.OpenSubKey("SOFTWARE", true);
            RegistryKey tabel = software.OpenSubKey("tabel", true);
            int triger = Convert.ToInt32(tabel.GetValue("triger"));
            tabel.Close();
            return triger;
        }

    }

}
