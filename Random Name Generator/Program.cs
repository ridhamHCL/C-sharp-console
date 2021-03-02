using System;
using System.Collections.Generic;
using System.Collections;

namespace Random_Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<string> nameList = new List<string> { "Ridham", "Meet", "Dhvanish", "Darshan" ,"Sachin","Parth"};
            for (int i = 0; i < nameList.Count; i++)
            {
                string temp = nameList[i];
                Random ran = new Random();
                int randomIndex = ran.Next(i, nameList.Count);
                nameList[i] = nameList[randomIndex];
                nameList[randomIndex] = temp;
            }
            foreach (string a in nameList)
                Console.WriteLine(a);

        }
    }
}
