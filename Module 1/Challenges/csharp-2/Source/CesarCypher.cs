using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        public string Crypt(string message)
        {
            if (message is null)
                throw new ArgumentNullException();
            else if (message.Equals(String.Empty))
                return message;
            else
            {
                var mes = message.ToLower();
                int steps = 3, alf = 26;
                string mesCrypt = "";

                for (int i = 0; i < mes.Length; i++)
                {
                    int numAsc = (int)mes[i];
                    if (numAsc == 32 || (numAsc >= 48 && numAsc <= 57))
                        mesCrypt += (char)numAsc;
                    else if (numAsc >= 97 && numAsc <= 122)
                    {
                        if (numAsc >= 120 && numAsc <= 122)
                            mesCrypt += (char)(numAsc + steps - alf);
                        else
                            mesCrypt += (char)(numAsc + steps);
                    }
                    else
                        throw new ArgumentOutOfRangeException();

                }
                return mesCrypt;
            }
        }

        public string Decrypt(string cryptedMessage)
        {
            if (cryptedMessage is null)
                throw new ArgumentNullException();
            else if (cryptedMessage.Equals(String.Empty))
                return cryptedMessage;
            else
            {
                var cryptMes = cryptedMessage.ToLower();
                int steps = 3, alf = 26;
                string decryptMes = "";

                for (int i = 0; i < cryptMes.Length; i++)
                {
                    int numAsc = (int)cryptMes[i];
                    if (numAsc == 32 || (numAsc >= 48 && numAsc <= 57))
                        decryptMes += (char)numAsc;
                    else if (numAsc >= 97 && numAsc <= 122)
                    {
                        if (numAsc >= 97 && numAsc <= 99)
                            decryptMes += (char)(numAsc - steps + alf);
                        else
                            decryptMes += (char)(numAsc - steps);
                    }
                    else
                        throw new ArgumentOutOfRangeException();
                }
                return decryptMes;
            }
        }
    }
}
