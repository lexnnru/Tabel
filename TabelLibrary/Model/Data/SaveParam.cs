using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelLibrary.Data
{
    public class SaveParam
    {
        public SaveParam() { }

        public SaveParam(string data)
        {
            string[] notjoin = data.Split(new string[1] { "@@" }, StringSplitOptions.None);
            from = notjoin[0];
            to = notjoin[1];
            smtp = notjoin[2];
            username = notjoin[3];
            subject = notjoin[4];
            message = notjoin[5];
            password = notjoin[6];
        }

        public string from { get; set; }
        public string to { get; set; }
        public string smtp { get; set; }
        public string username { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return $"{from}@@{to}@@{smtp}@@{username}@@{subject}@@{message}@@{password}";
        }
    }
}