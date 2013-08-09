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

            return number;
        }

        public string numberToLetterEncode(int number)
        {
            string letter = "";
            char numberChar = Convert.ToChar(number);
            letter = (Convert.ToString((char) (numberChar + 32)));

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
