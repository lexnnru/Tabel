using System;
using System.Text;

namespace TabelLibrary.Crypto
{
    public class Xor:Abstract.Crypto
    {
        private string password = "fcHd{5ZG5Zyp4fO@O46SMuuvm69hR32cWe@nUklK?69o7TCoxYD@EVfjpT4~?PC*aRPnkcHd{5ZG5Zyp4fO@O46SMuuvm69hR32cWe@nUklK?69o7TCoxYD@EVfjpT4~?PC*aRPnkC@1MKxMAT9R*kxP}%6BffjQhJq*DaIC@1MKxMAT9R*kxP}%6BffjQhJq*DaIcHd{5ZG5Zyp4fO@O46SMuuvm69hR32cWe@nUklK?69o7TCoxYD@EVfjpT4~?PC*aRPnkC@1MKxMAT9R*kxP}%6BffjQhJq*DaI";
        /// <summary>
        /// Задает задает символы которыми должен кодироваться текст
        /// </summary>
        public string Password
        {
            set
            {

                if (value.Length < 128)
                {
                    Console.WriteLine("слишком маленькая длина пароля");
                }
                else
                {
                    password = value;
                }
            }
            get
            {
                return password;
            }
        }
        /// <summary>
        /// Возвращает закодированный текст.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override byte[] Encode(string message)
        {
            byte[] messagecharmassiv = Encoding.UTF8.GetBytes(message);
            byte[] passcharmassiv = Encoding.UTF8.GetBytes(password);
            byte[] shifrovanni = new byte[messagecharmassiv.Length];
            for (var i = 0; i < messagecharmassiv.Length; i++)
            {
                int x = (messagecharmassiv[i] ^ passcharmassiv[i]);
                shifrovanni[i] = Convert.ToByte(x);
            }
            return shifrovanni;
        }
        /// <summary>
        ///Возвращает  раскодированный текст.
        /// </summary>
        /// <param name="codingmessage"></param>
        /// <returns></returns>
        public override string Decoding(byte[] codingmessage)
        {
            byte[] passcharmassiv = Encoding.UTF8.GetBytes(password);
            byte[] rasshifrovanni = new byte[codingmessage.Length];
            for (var i = 0; i < codingmessage.Length; i++)
            {
                int x = (codingmessage[i]) ^ (passcharmassiv[i]);
                rasshifrovanni[i] = Convert.ToByte(x);
            }         
            string Decoding = Encoding.UTF8.GetString(rasshifrovanni);
            return Decoding;
        }
        
    }

}
