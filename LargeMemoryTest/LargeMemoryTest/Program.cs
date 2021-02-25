using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace LargeMemoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new StreamReader("d:\\flat_all_firsthalf");
            System.Collections.Generic.LinkedList<string> allofit = new LinkedList<string>();
            //[] allofit = new string[310748665];
            //char[,] allofit = new char[155374333, 63]; 
            string s = sr.ReadLine();
            int count = 0;
            int lencount = 0;
            while(s != null)
            {
                //LInked List
                allofit.AddLast(s.Substring(0, s.Length - 4).ToLower());
                //allofit[count,0] = 
                //char[] tmp = s.Substring(0, s.Length - 4).ToLower().ToCharArray();
                //lencount = 0;
                //foreach (char c in tmp)
                //{
                //   allofit[count, lencount] = c;
                //    lencount++;
                //}
                //allofit.AddLast(s.Substring(0, s.Length - 4).ToLower());
                s = sr.ReadLine();
                count++;
            }

            count = 0;
            Stopwatch tictoc = new Stopwatch();
            tictoc.Start();
            foreach(var n in allofit)
            {
                //if (n.Contains("sharepoint"))
                if (n.IndexOf("sharepoint") != -1)
                {
                    count++;
                }
            }
            tictoc.Stop();
            System.Console.WriteLine(tictoc.ElapsedMilliseconds.ToString() + " : " + count.ToString());
            count = 0;
            tictoc.Reset();
            tictoc.Start();
            foreach (var n in allofit)
            {
                //if (n.Contains("outlook"))
                if (n.IndexOf("outlook") != -1)
                {
                    count++;
                }
            }
            tictoc.Stop();
            System.Console.WriteLine(tictoc.ElapsedMilliseconds.ToString() + " : " + count.ToString());
            count = 0;
            tictoc.Reset();
            tictoc.Start();
            foreach (var n in allofit)
            {
                //if (n.Contains("apple"))
                if (n.IndexOf("apple") != -1)
                {
                    count++;
                }
            }
            tictoc.Stop();
            System.Console.WriteLine(tictoc.ElapsedMilliseconds.ToString() + " : " + count.ToString());
            
            System.Console.WriteLine("Done.");
            System.Console.ReadLine();
        }
    }
}
