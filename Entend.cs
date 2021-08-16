using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
        	//Full_Name
          string firstName = "Shilla Fiel";
          string lastName = "Camia";
          string fullName = firstName + " " + lastName;
          Console.WriteLine("Name: " + fullName);
          
          string Course = "BSCS";
          Console.WriteLine("Course and Section: BSCS1A");
          Console.ReadLine();
        }
    }
}