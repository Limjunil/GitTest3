using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            // {    2023.01.05.     Add Console / Test1
            Console.WriteLine("ssss");
            // }    2023.01.05.     Add Console / Test1

            Console.WriteLine();    



            // {    2023.01.05.     Add New feature user input / Beta
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.Write("Input Cm value");
            userInput= Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // }    2023.01.05.     Add New feature user input / Beta

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
        // { 2023.01.05.    Add new feature SetInch func / Gamma
            private set { SetInch(value); }
        }

        // 생성자
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{Centimeter} cm는 {Inch} inch 입니다.");
        }

        private void SetInch(float inchValue)
        {
            Centimeter = (int)(inchValue / ONE_INCH);
        }

        // } 2023.01.05.    Add new feature SetInch func / Gamma

    } // class Ruler
    
}