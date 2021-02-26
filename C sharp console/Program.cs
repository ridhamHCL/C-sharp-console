using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace C_sharp_console
{
    class Program
    {
        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }
        static string caesarCipher(string s, int k)
        {
            string output = string.Empty;

            foreach (char ch in s)
                output += Cipher(ch, k);

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string");

            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            Console.WriteLine(result);
        }
    }
}
