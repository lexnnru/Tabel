using System;
using System.IO;
using TabelLibrary.Data;

namespace TabelLibrary
{
    public class Settings
    {
        public SaveParam saveParam { get; set; } = null;
        Crypto.Abstract.Crypto abstractCrypto;
        public Settings(Crypto.Abstract.Crypto cry)
        {
            abstractCrypto = cry;
        }

        public void Save(SaveParam saveParam, string pathWhereToSave = "", string nameFileWithSettings = "\\settings")
        {
            if (pathWhereToSave == "")
                pathWhereToSave = System.Windows.Forms.Application.StartupPath;

            File.WriteAllBytes(pathWhereToSave + nameFileWithSettings, abstractCrypto.Encode(saveParam.ToString()));
        }

        public void Open(string pathWhereToSave = "", string nameFileWithSettings = "\\settings")
        {
            if (pathWhereToSave == "")
                pathWhereToSave = System.Windows.Forms.Application.StartupPath;
            byte[] securesettings = File.ReadAllBytes(pathWhereToSave + nameFileWithSettings);
            saveParam = new SaveParam(abstractCrypto.Decoding(securesettings));
        }
    }
}