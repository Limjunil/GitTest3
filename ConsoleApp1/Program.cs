﻿using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54f;

        public int Centimeter { get; set; } = 0;

        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }

        // 생성자
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{Centimeter} cm는 {Inch} inch 입니다.");
        }
    } // class Ruler
}