using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        #region Functions - Block Of code to Make Code More Readable [Signiture - Body]
        //// Static Function

        static void PrintShapes(int Count , string Pattern) {

            for (int i = 0; i < Count; i++) {
                Console.WriteLine(Pattern + i);
            }

        }

       

        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Demo C# 04 !");

            #region String
            ////The String is BuiltIn Class - Reference Type - Array of Characters
            //string Name; // Declare For Refrence of Type String - This Reference Is Refering to the Default Value 
            ////CLR - Will Locate 4 Bytes In stack memory --> CLR will Locate 0 Bytes In Heap (when you set value "=" Only)
            //Name = new string("Atlants");//CLR - Will Locate 8 Bytes In Heap memory
            //Name = "Othman"; //Syntax Sugar
            ////lowwer lines count = more preformance
            //Console.WriteLine(Name);

            //Console.WriteLine("-------\n");
            //string Name01 = "AHMED";
            //string Name02 = "AYA";

            //Console.WriteLine($"name 01 :{Name01}");
            //Console.WriteLine($"name 01 Hash :{Name01.GetHashCode()}");

            //Console.WriteLine($"name 02 :{Name02}");
            //Console.WriteLine($"name 02 Hash :{Name02.GetHashCode()}");
            //Console.WriteLine("-------\n");
            //Name02 = Name01;
            //Console.WriteLine($"name 01 - {Name01} - Hash :{Name01.GetHashCode()}");
            //Console.WriteLine($"name 02 - {Name02} - Hash :{Name02.GetHashCode()}");
            #endregion

            #region String Builder - DataType - Concept Gives You abilty to edit the same location in memory that normal string cannot
            //StringBuilder Msg;
            //Msg = new StringBuilder ("Helllo");
            //Console.WriteLine($"name 01 - {Msg} - Hash :{Msg.GetHashCode()}");
            //Console.WriteLine("-------\n");

            //Msg.Append("Rana !");
            //Console.WriteLine($"name 01 - {Msg} - Hash :{Msg.GetHashCode()}");
            //Console.WriteLine("-------\n");
            #endregion

            #region Array - Refernce Type - Fixed Size - Start From 0
            ////One Dimension Array
            int[] Numbers01 = new int[3] {1 , 2 , 3} ; //heap
            int[] Numbers02 ;
            int[] Numbers03 ;

            ////foreach - no operations
            //foreach (int Numbers in Numbers01) {
            //    Console.WriteLine(Numbers);
            //}
            //Console.WriteLine("-------\n");

            ////for
            //for (int i = 0; i < Numbers01.Length; i++)
            //{
            //    Console.WriteLine(Numbers01[i]);
            //}

            //Console.WriteLine($"Lenth is: {Numbers01.Length}");


            ////Two Dimension Array
            // Array of Rowas and Colomns
            //int [,] Numbers04 = new int[3, 5] { /*1*/{1,2,3,4,5 },/*2*/{ 1, 2, 3, 4, 5 },/*3*/{ 1, 2, 3, 4, 5 }, } ;

            //for (int i = 0; i < 3; i++) {
            //    Console.WriteLine($"Std Num: {i+1}");

            //    for (int j = 0; j < 5; j++) {
            //        Console.WriteLine($"Enter Grade: {j+1}");
            //        Numbers04 [i,j] = int.Parse(Console.ReadLine());

            //    }
            //    Console.WriteLine(Numbers04[0,0]);

            //}

            #endregion

            Program.PrintShapes(5,"NENENE");




        }
    }
}
