﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint0.Task1.V0.Lib;
namespace Tyuiu.NazarenkoVV.Sprint0.Task1.V0

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Виолетта"));
            Console.ReadKey();
        }
    }
}
