using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace YouTobe_DWN
{
    public partial class Form1 : Form
    {
        static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

        public Form1()
        {
            InitializeComponent();
        }
        //*
        private static char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }
        //*

        private void button1_Click(object sender, EventArgs e)
        {
            int PasswordAmount = 1;
            int PasswordLength = int.Parse(txtPWD.Text);

            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string AllChar = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

            //*
            //Console.WriteLine("\nHow many passwords should be generated?:");
            //PasswordAmount = 1;
            //Console.WriteLine("Enter the password length (chars):");
          //  PasswordLength = 8;

            string[] AllPasswords = new string[PasswordAmount];
            //*
            for (int i = 0; i < PasswordAmount; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int n = 0; n < PasswordLength; n++)
                {
                    sb = sb.Append(GenerateChar(AllChar));
                }

                AllPasswords[i] = sb.ToString();
            }
          lblPWD.Text = "Generált PWD: " + AllPasswords[0];
            //MessageBox.Show(AllPasswords[0]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chLittles.Checked) { }
        }
    }
}
