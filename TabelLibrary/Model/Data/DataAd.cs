
namespace TabelLibrary.Data
{
    public class DataAd
    {
       public string dataRozd, organization, dolznost, otdel, Gorod, Ulitsa, office, vnutrNum, MobNum, sAMAccountName;
        public string thisuser; //SystemInformation.UserName; //SystemInformation.UserName;// "a.pankov"; //SystemInformation.UserName;
        public string Boss = "";
        public string EmailBoss = "";
        public string Email = "";
        public string FullName = "";
      public DataAd (string thisuser)
        {
            this.thisuser = thisuser;
        }
    }
    
}
