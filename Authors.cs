using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array obAuthorID = Array.CreateInstance(typeof(string), 3);
            Array obAddress = Array.CreateInstance(typeof(string), 3);
            Array objStabe = Array.CreateInstance(typeof(string), 3);

            string input = "";

            for (int i = 0; i < Authors.Length; i++)
            {
                Console.WriteLine("Enter the ID of author ; ");
                input = Console.ReadLine();
                obAuthorID.SetValue(Convert.ToInt32(input), i);
                Console.Write("Enter the name of author : ");
                input = Console.ReadLine();
                Program.SetValue(input, i);
                Console.Write("Enter the address : ");
                input = Console.ReadLine();
                obAddress.SetValue(input, i);
                Console.WriteLine("Enter the name of state : ");
                input = Console.ReadLine();
                objStabe.SetValue(input, i);
                Console.WriteLine();
            }

            Console.WriteLine("\nDetails of the authors :\n");
            Console.WriteLine("Author ID\TName\tAđres\t\t\tState");
            for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
            {
                Console.Write(objAuthorID.GetValue(i) + "\t\t");
                Console.Write(obAuthorNames.Getvalue(i) + "\t");
                Console.Write(objAddress.GetValue(i) + "\t");
                Console.WriteLine(objStabe.GetValue(i));
            }
            Array.Sort(obAuthorName);
            Console.WriteLine("\n Author names after sorting : \n");
            for( int i = 0; i <= obAuthorNames.GetUPperBond(0); i++)
            {
                Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
            }

        }
    }
}
    

