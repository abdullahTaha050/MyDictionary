using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Abdullah Taha");
            students.Add(2, "Mehmet");
            students.Add(3, "Ahmet");
            Console.WriteLine(students.Length);
            students.Show();
        }
    }
}
