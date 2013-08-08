using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaApp_v2
{
    class Rotor
    {
        int[] encryptRotor;
        int[] decryptRotor;
        int rand1 = 0;
        bool rotorCheck = false;
        public Random[] randSeed;

        public Rotor(int rotorLength, int rotorNum)
        {
            randSeed = new Random[3];
            randSeed[0] = new Random(4985);
            randSeed[1] = new Random(203);
            randSeed[2] = new Random(1004238);
            encryptRotor = new int[rotorLength];
            decryptRotor = new int[rotorLength];

                for (int k = 0; k < rotorLength; k++)
                {
                    encryptRotor[k] = -1;
                    decryptRotor[k] = -1;
                }
                for (int i = 0; i < rotorLength; i++)
                {
                    while (rotorCheck == false)
                    {
                        rand1 = randSeed[rotorNum - 1].Next(rotorLength);
                        rotorCheck = true;
                        for (int j = 0; j < rotorLength; j++)
                        {
                            if (encryptRotor[j] == rand1)
                                rotorCheck = false;
                        }
                    }
                    rotorCheck = false;
                    encryptRotor[i] = rand1;
                    decryptRotor[rand1] = i;

                }
                #region oldEncryptRotor1
                //encryptRotor[0] = 5;
                //encryptRotor[1] = 8;
                //encryptRotor[2] = 4;
                //encryptRotor[3] = 3;
                //encryptRotor[4] = 9;
                //encryptRotor[5] = 0;
                //encryptRotor[6] = 7;
                //encryptRotor[7] = 2;
                //encryptRotor[8] = 6;
                //encryptRotor[9] = 1;
                #endregion
            //else if (rotorNum == 2)
            //{
            //    for (int k = 0; k < rotorLength; k++)
            //    {
            //        encryptRotor[k] = -1;
            //        decryptRotor[k] = -1;
            //    }
            //    for (int i = 0; i < rotorLength; i++)
            //    {
            //        while (rotorCheck == false)
            //        {
            //            rand1 = randSeed[1].Next(10);
            //            rotorCheck = true;
            //            for (int j = 0; j < rotorLength; j++)
            //            {
            //                if (encryptRotor[j] == rand1)
            //                    rotorCheck = false;
            //            }
            //        }
            //        rotorCheck = false;
            //        encryptRotor[i] = rand1;
            //        decryptRotor[rand1] = i;

            //    }
                #region oldEncryptRotor2
                //encryptRotor[0] = 9;
                //encryptRotor[1] = 8;
                //encryptRotor[2] = 6;
                //encryptRotor[3] = 1;
                //encryptRotor[4] = 0;
                //encryptRotor[5] = 7;
                //encryptRotor[6] = 5;
                //encryptRotor[7] = 3;
                //encryptRotor[8] = 4;
                //encryptRotor[9] = 2;
                #endregion
            //}
            //else if (rotorNum == 3)
            //{
            //    for (int k = 0; k < rotorLength; k++)
            //    {
            //        encryptRotor[k] = -1;
            //        decryptRotor[k] = -1;
            //    }
            //    for (int i = 0; i < rotorLength; i++)
            //    {
            //        while (rotorCheck == false)
            //        {
            //            rand1 = randSeed[2].Next(10);
            //            rotorCheck = true;
            //            for (int j = 0; j < rotorLength; j++)
            //            {
            //                if (encryptRotor[j] == rand1)
            //                    rotorCheck = false;
            //            }
            //        }
            //        rotorCheck = false;
            //        encryptRotor[i] = rand1;
            //        decryptRotor[rand1] = i;
            //    }
                #region oldEncryptRotor3
                //encryptRotor[0] = 3;
                //encryptRotor[1] = 7;
                //encryptRotor[2] = 6;
                //encryptRotor[3] = 9;
                //encryptRotor[4] = 2;
                //encryptRotor[5] = 8;
                //encryptRotor[6] = 1;
                //encryptRotor[7] = 4;
                //encryptRotor[8] = 0;
                //encryptRotor[9] = 5;
                #endregion
            //}

            #region oldDecryptRotors
            //reverse of encrypt rotor
            //if (rotorNum == 1)
            //{
            //    decryptRotor[0] = 5;
            //    decryptRotor[1] = 9;
            //    decryptRotor[2] = 7;
            //    decryptRotor[3] = 3;
            //    decryptRotor[4] = 2;
            //    decryptRotor[5] = 0;
            //    decryptRotor[6] = 8;
            //    decryptRotor[7] = 6;
            //    decryptRotor[8] = 1;
            //    decryptRotor[9] = 4;
            //}
            //else if (rotorNum == 2)
            //{
            //    decryptRotor[0] = 4;
            //    decryptRotor[1] = 3;
            //    decryptRotor[2] = 9;
            //    decryptRotor[3] = 7;
            //    decryptRotor[4] = 8;
            //    decryptRotor[5] = 6;
            //    decryptRotor[6] = 2;
            //    decryptRotor[7] = 5;
            //    decryptRotor[8] = 1;
            //    decryptRotor[9] = 0;
            //}
            //else if (rotorNum == 3)
            //{
            //    decryptRotor[0] = 8;
            //    decryptRotor[1] = 6;
            //    decryptRotor[2] = 4;
            //    decryptRotor[3] = 0;
            //    decryptRotor[4] = 7;
            //    decryptRotor[5] = 9;
            //    decryptRotor[6] = 2;
            //    decryptRotor[7] = 1;
            //    decryptRotor[8] = 5;
            //    decryptRotor[9] = 3;
            //}
            #endregion
        }

        public int encrypt(int letter)
        {
            int encryptedLetter = new int();
            encryptedLetter = encryptRotor[letter];
            return encryptedLetter;
        }

        public int decrypt(int letter)
        {
            int decryptedLetter = new int();
            decryptedLetter = decryptRotor[letter];
            return decryptedLetter;
        }
    }
}
