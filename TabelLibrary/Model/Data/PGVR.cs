using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelLibrary.Model.Data
{
    public class PGVR
    {
        public PGVR(string pgvr, string descr) 
            {
            Pgvr = pgvr;
            Descr = descr;


        }
        string pgvr;
        public string Pgvr { 
                set { pgvr = value; } 
            get { return pgvr; } }
        string descr;
        public string Descr
        {
            set { descr = value; }
            get { return descr; }
        }
        public override string ToString()
        {
            return Pgvr.ToString()+ " " + Descr;
        }
    }
}
