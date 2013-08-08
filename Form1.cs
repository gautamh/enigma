using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnigmaApp_v2
{
    public partial class Enigma : Form
    {
        string input = "";
        string output = "";
        int processingItem = new int();
        int rotation1 = new int();
        int rotation2 = new int();
        int rotation3 = new int();
        char testChar = ' ';
        static int length = 94;
        Rotor rotorI = new Rotor(length, 1);
        Rotor rotorII = new Rotor(length, 2);
        Rotor rotorIII = new Rotor(length, 3);
        HelperFns helpers = new HelperFns();

        public Enigma()
        {
            InitializeComponent();
            //lblRand.Text = Convert.ToString(Convert.ToInt32(testChar));
            //add start rotation
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            rotation1 = Convert.ToInt32(txtRotorIStart.Text);
            rotation2 = Convert.ToInt32(txtRotorIIStart.Text);
            rotation3 = Convert.ToInt32(txtRotorIIIStart.Text);
            input = rxtInput.Text;
            while (input.Length > 0)
            {
                //take first character, change to number
                processingItem = letterToNumberDecode(input.Substring(0, 1));
                //encrypt processingItem
                processingItem = runEncrypt(processingItem);
                //add processingItem, change to letter, and add to output
                output = output + numberToLetterEncode(processingItem);
                //remove processed character from string
                input = input.Remove(0,1);
            }
            rxtOutput.Text = output;
            output = "";
            //lblRand.Text = Convert.ToString(Convert.ToInt32(testChar));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            rotation1 = Convert.ToInt32(txtRotorIStart.Text);
            rotation2 = Convert.ToInt32(txtRotorIIStart.Text);
            rotation3 = Convert.ToInt32(txtRotorIIIStart.Text);
            input = rxtInput.Text;
            while (input.Length > 0)
            {
                //take first character, change to number
                processingItem = letterToNumberDecode(input.Substring(0, 1));
                //decrypt processingItem
                processingItem = runDecrypt(processingItem);
                //add processingItem, change to letter, and add to output
                output = output + numberToLetterEncode(processingItem);
                //remove processed character from string
                input = input.Remove(0, 1);
            }
            rxtOutput.Text = output;
            output = "";
            //lblRand2.Text = rotorII.randSeed[0].Next(10).ToString();
        }

        public int runEncrypt(int encryptorInput)
        {
            int encryptorProcessingItem = encryptorInput;

            //add rotorI rotation
            encryptorProcessingItem = (encryptorProcessingItem + rotation1) % length;
            //rotorI encrypt
            encryptorProcessingItem = rotorI.encrypt(encryptorProcessingItem);
            //add rotorII rotation
            encryptorProcessingItem = (encryptorProcessingItem + rotation2) % length;
            //rotorII encrypt
            encryptorProcessingItem = rotorII.encrypt(encryptorProcessingItem);
            //add rotorIII rotation
            encryptorProcessingItem = (encryptorProcessingItem + rotation3) % length;
            //rotorIII encrypt
            encryptorProcessingItem = rotorIII.encrypt(encryptorProcessingItem);
            //increase rotorI rotation
            rotation1++;
            //increase rotorII rotation if rotorI rotation is divisible by 2 (every other time)
            if ((rotation1 % 2) == 0)
                rotation2++;
            //increase rotorIII rotation if rotorII rotation is divisible by 3 (every third time)
            if ((rotation2 % 3) == 0)
                rotation3++;
            //if rotation1 > 1 full rotation, reset rotation1
            if (rotation1 > (length - 1))
                rotation1 = 0;
            //if rotation2 > 1 full rotation, reset rotation1
            if (rotation2 > (length - 1))
                rotation2 = 0;
            //if rotation3 > 1 full rotation, reset rotation1
            if (rotation3 > (length - 1))
                rotation3 = 0;
            //output
            return encryptorProcessingItem;
        }

        public int runDecrypt(int decryptorInput)
        {
            int decryptorProcessingItem = decryptorInput;

            //rotorIII decrypt
            decryptorProcessingItem = rotorIII.decrypt(decryptorProcessingItem);
            //subtract rotorIII rotation
            if ((decryptorProcessingItem - rotation3) >= 0)
                decryptorProcessingItem = decryptorProcessingItem - rotation3;
            else
                decryptorProcessingItem = (decryptorProcessingItem - rotation3) + length;
            //rotorII decrypt
            decryptorProcessingItem = rotorII.decrypt(decryptorProcessingItem);
            //subtract rotorII rotation
            if ((decryptorProcessingItem - rotation2) >= 0)
                decryptorProcessingItem = decryptorProcessingItem - rotation2;
            else
                decryptorProcessingItem = (decryptorProcessingItem - rotation2) + length;
            //rotorI decrypt
            decryptorProcessingItem = rotorI.decrypt(decryptorProcessingItem);
            //subtract rotorI rotation
            if ((decryptorProcessingItem - rotation1) >= 0)
                decryptorProcessingItem = decryptorProcessingItem - rotation1;
            else
                decryptorProcessingItem = (decryptorProcessingItem - rotation1) + length;
            //increase rotorI rotation
            rotation1++;
            //increase rotorII rotation if rotorI rotation is divisible by 2 (every other time)
            if ((rotation1 % 2) == 0)
                rotation2++;
            //increase rotorIII rotation if rotorII rotation is divisible by 3 (every third time)
            if ((rotation2 % 3) == 0)
                rotation3++;
            //if rotation1 > 1 full rotation, reset rotation1
            if (rotation1 > (length - 1))
                rotation1 = 0;
            //if rotation2 > 1 full rotation, reset rotation1
            if (rotation2 > (length - 1))
                rotation2 = 0;
            //if rotation3 > 1 full rotation, reset rotation1
            if (rotation3 > (length - 1))
                rotation3 = 0;
            //output
            return decryptorProcessingItem;
        }

        public int letterToNumberDecode(string letter)
        {
            int number = new int();
            char letterChar = Convert.ToChar(letter);
            number = (Convert.ToInt32(letterChar)) - 32;

            #region oldDecode
            //if (letter == "a")
            //    number = 0;
            //else if (letter == "b")
            //    number = 1;
            //else if (letter == "c")
            //    number = 2;
            //else if (letter == "d")
            //    number = 3;
            //else if (letter == "e")
            //    number = 4;
            //else if (letter == "f")
            //    number = 5;
            //else if (letter == "g")
            //    number = 6;
            //else if (letter == "h")
            //    number = 7;
            //else if (letter == "i")
            //    number = 8;
            //else if (letter == "j")
            //    number = 9;
            //else if (letter == "k")
            //    number = 10;
            //else if (letter == "l")
            //    number = 11;
            //else if (letter == "m")
            //    number = 12;
            //else if (letter == "n")
            //    number = 13;
            //else if (letter == "o")
            //    number = 14;
            //else if (letter == "p")
            //    number = 15;
            //else if (letter == "q")
            //    number = 16;
            //else if (letter == "r")
            //    number = 17;
            //else if (letter == "s")
            //    number = 18;
            //else if (letter == "t")
            //    number = 19;
            //else if (letter == "u")
            //    number = 20;
            //else if (letter == "v")
            //    number = 21;
            //else if (letter == "w")
            //    number = 22;
            //else if (letter == "x")
            //    number = 23;
            //else if (letter == "y")
            //    number = 24;
            //else if (letter == "z")
            //    number = 25;
            //else if (letter == " ")
            //    number = 26;
            #endregion

            return number;
        }

        public string numberToLetterEncode(int number)
        {
            string letter = "";
            char numberChar = Convert.ToChar(number);
            letter = (Convert.ToString((char) (numberChar + 32)));
            #region oldEncode
            //if (number == 0)
            //    letter = "a";
            //if (number == 1)
            //    letter = "b";
            //if (number == 2)
            //    letter = "c";
            //if (number == 3)
            //    letter = "d";
            //if (number == 4)
            //    letter = "e";
            //if (number == 5)
            //    letter = "f";
            //if (number == 6)
            //    letter = "g";
            //if (number == 7)
            //    letter = "h";
            //if (number == 8)
            //    letter = "i";
            //if (number == 9)
            //    letter = "j";
            //if (number == 10)
            //    letter = "k";
            //if (number == 11)
            //    letter = "l";
            //if (number == 12)
            //    letter = "m";
            //if (number == 13)
            //    letter = "n";
            //if (number == 14)
            //    letter = "o";
            //if (number == 15)
            //    letter = "p";
            //if (number == 16)
            //    letter = "q";
            //if (number == 17)
            //    letter = "r";
            //if (number == 18)
            //    letter = "s";
            //if (number == 19)
            //    letter = "t";
            //if (number == 20)
            //    letter = "u";
            //if (number == 21)
            //    letter = "v";
            //if (number == 22)
            //    letter = "w";
            //if (number == 23)
            //    letter = "x";
            //if (number == 24)
            //    letter = "y";
            //if (number == 25)
            //    letter = "z";
            //if (number == 26)
            //    letter = " ";
            #endregion
            return letter;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rotation1 = 0;
            rotation2 = 0;
        }

        private void rxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
