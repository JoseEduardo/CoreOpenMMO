namespace COMMO.Network.Cryptography
{
    public static class Tools
    {
        public static uint AdlerChecksum(byte[] data, int index, int length)
        {
            const ushort adler = 65521;

            uint a = 1, b = 0;

            while (length > 0)
            {
                int tmp = (length > 5552) ? 5552 : length;
                length -= tmp;

                do
                {
                    a += data[index++];
                    b += a;
                } while (--tmp > 0);

                a %= adler;
                b %= adler;
            }

            return (b << 16) | a;
        }
    }
}