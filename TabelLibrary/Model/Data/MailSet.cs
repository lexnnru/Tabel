namespace TabelLibrary.Data
{
    public class MailSet:SaveParam
    {
        public MailSet() { }
       public MailSet(string savedata): base(savedata) { }
        public MailSet(string savedata, string fileforsend) : base(savedata)
        {
            this.fileforsend = fileforsend;
        }
        public string fileforsend { get; set; }
    }
}