using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Windows.Forms;

namespace TabelLibrary
{
    public class Ad
    {
        DirectoryEntry directoryObjectU = new DirectoryEntry("LDAP://OU=Нижний Новгород,OU=SINTEK,DC=intranet-sintek,DC=net");
        public Data.DataAd Getsettings(out string error)
        {
            error = "";
            Data.DataAd ad = new Data.DataAd(SystemInformation.UserName);
            byte[] data;
            try
            {
                foreach (DirectoryEntry child2 in directoryObjectU.Children)   //перебираем все объекты
                {
                    string objectCategory = child2.Properties["objectCategory"][0].ToString(); // получем Категорию объекта 
                    if (objectCategory == "CN=Person,CN=Schema,CN=Configuration,DC=intranet-sintek,DC=net")   //если это учетка пользователя, то получаем его параметры
                    {
                        if (child2.Properties.Contains("sAMAccountName"))
                        {
                            ad.sAMAccountName = child2.Properties["sAMAccountName"][0].ToString();
                            if (ad.sAMAccountName == ad.thisuser)
                            {
                                if (child2.Properties.Contains("displayName"))
                                {
                                    ad.FullName = child2.Properties["name"][0].ToString();
                                }
                                else { continue; }
                                if (child2.Properties.Contains("pager")) { ad.dataRozd = child2.Properties["pager"][0].ToString(); } else { ad.dataRozd = "X"; }
                                if (child2.Properties.Contains("company")) { ad.organization = child2.Properties["company"][0].ToString(); } else { ad.organization = "X"; }
                                if (child2.Properties.Contains("title")) { ad.dolznost = child2.Properties["title"][0].ToString(); } else { ad.dolznost = "X"; }
                                if (child2.Properties.Contains("department")) { ad.otdel = child2.Properties["department"][0].ToString(); } else { ad.otdel = "X"; }
                                if (child2.Properties.Contains("l")) { ad.Gorod = child2.Properties["l"][0].ToString(); } else { ad.Gorod = "X"; }
                                if (child2.Properties.Contains("streetAddress")) { ad.Ulitsa = child2.Properties["streetAddress"][0].ToString(); } else { ad.Ulitsa = "X"; }
                                if (child2.Properties.Contains("physicalDeliveryOfficeName")) { ad.office = child2.Properties["physicalDeliveryOfficeName"][0].ToString(); } else { ad.office = "X"; }
                                if (child2.Properties.Contains("telephoneNumber")) { ad.vnutrNum = child2.Properties["telephoneNumber"][0].ToString(); } else { ad.vnutrNum = "X"; }
                                if (child2.Properties.Contains("mobile")) { ad.MobNum = child2.Properties["mobile"][0].ToString(); } else { ad.MobNum = "X"; }
                                if (child2.Properties.Contains("manager")) { ad.Boss = child2.Properties["manager"][0].ToString(); } else { ad.Boss = "X"; }
                                if (child2.Properties.Contains("mail")) { ad.Email = child2.Properties["mail"][0].ToString(); } else { ad.Email = "X"; }
                                if (child2.Properties.Contains("jpegPhoto"))
                                {
                                    data = child2.Properties["jpegPhoto"].Value as byte[];
                                    if (data != null)
                                    {
                                        if (File.Exists(Application.StartupPath + "\\foto.jpg"))
                                        {
                                            File.Delete(Application.StartupPath + "\\foto.jpg");
                                            File.WriteAllBytes(Application.StartupPath + "\\foto.jpg", data);
                                        }
                                        else
                                        {
                                            File.WriteAllBytes(Application.StartupPath + "\\foto.jpg", data);
                                            // pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\foto.jpg");
                                        }

                                    };
                                }
                            }
                            else { continue; }
                        }
                    }
                    DirectoryEntry directoryObjectBoss = new DirectoryEntry("LDAP://" + ad.Boss);
                    if (directoryObjectBoss.Properties.Contains("mail")) { ad.EmailBoss = directoryObjectBoss.Properties["mail"][0].ToString(); } else { ad.EmailBoss = "X"; }
                }
                return ad;
            }
            catch (Exception exep)
            {
                error = exep.Message;
                return ad;
            }
        }
    }
}