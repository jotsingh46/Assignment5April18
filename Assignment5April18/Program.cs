using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5April18
{
    class Program
    {
        static void Main(string[] args)
        {
			string line = "Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine.";
			string word = line.split(' ');
			string worrd = "";
			int counter = 0;
			foreach(string s in words){
				if(s.Length > counter)
				{
					word =s;
					counter = s.length;
				}
			}
			
			Console.WriteLine("the longest word is"+word);
			Console.ReadLine();
		}
	}
}
