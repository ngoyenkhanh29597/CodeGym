﻿using System;
namespace SystemTime
{
    class Program 
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            //System.Console.WriteLine("Datetime Now is :" + localDate);
            Console.WriteLine(localDate.ToString("dd/MM/yyyy hh:mm:ss"));
        }
    }
}
