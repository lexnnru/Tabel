namespace TabelLibrary.Crypto.Abstract
{
    public abstract class Crypto
    {
        public abstract byte[] Encode(string message);
        public abstract string Decoding(byte[] codingmessage);
    }
}
