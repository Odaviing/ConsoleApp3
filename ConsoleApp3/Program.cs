using System;

namespace ConsoleApp3
{
    class Program
    {
        public static int size_check()
        {
            string value;
            int size = 0;
            bool check = false;
            while (!check)
            {
                value = Console.ReadLine();
                check = int.TryParse(value, out size);
                if (check == false)
                {
                    Console.WriteLine("YOU NEED TO INPUT THE NUMBER!");
                }
            }
            return size;
        }

        public static double array_element()
        {
            string element;
            double d_element = 0;
            bool el_check = false;
            while (!el_check)
            {
                element = Console.ReadLine();
                el_check = double.TryParse(element, out d_element);
                if (el_check == false)
                {
                    Console.WriteLine("I SAID REAL NUMBERS!");
                }
            }
            return d_element;
        }

        public static void sorting(double[] some_array, int some_size, int choice, int sort)
        {
            double temp;
            if (sort == 1)
            {
                for (int i = 0; i < some_size; i++)
                {

                    for (int j = 0; j < some_size - i - 1; j++)
                    {
                        if (some_array[j] > some_array[j + 1])
                        {
                            temp = some_array[j];
                            some_array[j] = some_array[j + 1];
                            some_array[j + 1] = temp;

                        }
                    }

                }
            }

            if (sort == 2)
            {
                for (int i = 0; i < some_size; i++)
                {

                    for (int j = 0; j < some_size - i - 1; j++)
                    {
                        if (some_array[j] < some_array[j + 1])
                        {
                            temp = some_array[j];
                            some_array[j] = some_array[j + 1];
                            some_array[j + 1] = temp;

                        }
                    }

                }
            }
            Console.WriteLine("That's your sorted array, witness it in all of it's glory:");
            for (int i = 0; i < some_size; i++)
            {
                Console.WriteLine(some_array[i]);
            }

            Console.WriteLine("And that's the same array after your choice:");
                if (choice == 1)
            {
                for (int i = 0; i < some_size; i++)
                {
                    if (some_array[i] % 2 == 0)
                    {
                        Console.WriteLine(some_array[i]);
                    }
                }
            }
            if (choice == 2)
            {
                for (int i = 0; i < some_size; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(some_array[i]);
                    }
                }
            }


        }

        public static int choosing()
        {
            int final_choice = 0;
            while (final_choice != 1 && final_choice != 2)
            {
                final_choice = size_check();
                if (final_choice != 1 && final_choice != 2)
                {
                    Console.WriteLine("CHOOSE 1 OR 2 YOU IDIOT!");
                }
            }
            return final_choice;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Show me the size of the array");
            int arr_size = size_check();
            double[] arr = new double[arr_size];
            Console.WriteLine("Now let's fill this array");
            for (int i = 0; i < arr_size; i++)
            {
                Console.WriteLine("Show me some numbers");
                arr[i] = array_element();
                Console.WriteLine("Your element is:" + arr[i]);
                Console.WriteLine("");
            }
            
            Console.WriteLine("Lets check this out");
            Console.WriteLine("Press 1 if you want to see a even elements, press 2 if you want to see elements with even indexes");
            int output_choice = choosing();
            Console.WriteLine("It's time to sort our array. Press 1 if you want to sort elements in ascending order, or press 2 for descending order");
            int sort_choice = choosing();
            sorting(arr, arr_size, output_choice, sort_choice);



            
        }
    }
}
