using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your cock is big, but how big is your array?");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[size];
            Console.WriteLine("Now lets fill this big array, shall we?");
            string number = "";
            double i_check;
            
            for (int i = 0; i < size; i++)
            {
                bool check = false;
                Console.WriteLine("Enter the number:");
                while (!check)
                {
                    number = Console.ReadLine();
                    check = Double.TryParse(number, out i_check);
                    if (check == false)
                    {
                        Console.WriteLine("ARE YOU RETARDED OR SOMETHING? YOU SHOULD ENTER THE NUMBERS!");
                    }
                }
                arr[i] = Convert.ToDouble(number);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Now lets do some sorting of our array");
            double temp;
            for (int i = 0; i < size; i++)
            {
                
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    
                }
            }
            Console.WriteLine("Lets check this out");
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }


            Console.WriteLine("Now lets do this one more time, enter the size:");
            int size1 = Convert.ToInt32(Console.ReadLine());
            double[] arr1 = new double[size];
            Console.WriteLine("Fill the new one:");
            string number1 = "";
            double i_check1;

            for (int i = 0; i < size; i++)
            {
                bool check1 = false;
                Console.WriteLine("Enter the number:");
                while (!check1)
                {
                    number1 = Console.ReadLine();
                    check1 = Double.TryParse(number1, out i_check1);
                    if (check1 == false)
                    {
                        Console.WriteLine("ARE YOU RETARDED OR SOMETHING? YOU SHOULD ENTER THE NUMBERS!");
                    }
                }
                arr[i] = Convert.ToDouble(number1);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Lets sort this one too");
            double temp1;
            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp1 = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp1;
                    }

                }
            }
            Console.WriteLine("Lets check this out");
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
