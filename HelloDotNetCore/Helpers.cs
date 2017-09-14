using System;

struct code_styles
{
    public string style;
    public string version;
    public string id;
};

namespace HelloDotNetCore
{
    public class Helpers
    {
        public void max_size_of_data_type()
        {
            Console.WriteLine("Max int: {0}", sizeof(int));
            Console.WriteLine("Max double: {0}", sizeof(double));
            Console.WriteLine("Max float: {0}", sizeof(float));
            Console.WriteLine("Max long: {0}", sizeof(long));
        }

        /// <summary>
        /// Dynamic types are similar to object types except that type checking for object type variables takes place at
        ///  compile time, whereas that for the dynamic type variables takes place at run time.
        /// </summary>
        public void dynamic_types()
        {
            dynamic cat = "cat matt";

            dynamic dog = 340;
        }

        public void explicit_type_conversion()
        {
            double d_number = 3.3434343;
            int i_num;
            
            //Cast double to int
            i_num = (int) d_number;
            Console.WriteLine("Original doble {0}", d_number);
            Console.WriteLine("Doble to Int {0}", i_num);
        }

        public void inline_conditional_operators()
        {
            const bool yes = true;
            dynamic i_love_c_sharp = yes ? "I love c#" : "hate";
            Console.WriteLine(i_love_c_sharp);
        }

        public void for_loops()
        {
            for (int counter = 1; counter < 20; counter++)
            {
                Console.Write("{0}, ", counter);
            }
        }

        /// <summary>
        /// C# provides a special data types, the nullable types, to which you can assign normal range of values as 
        /// well as null values.
        /// </summary>
        public void nullables()
        {
            int? num1 = null;
            int? num2 = 45;
            Console.WriteLine(num1);
        }

        public void array_examples()
        {
            double[] container = new double[5];

            for (int counterIndex = 0; counterIndex < 5; counterIndex++)
            {
                container[counterIndex] = counterIndex;
            }

            foreach (var item in container)
            {
                Console.Write("item: {0} ", item);
            }
            
        }

        /// <summary>
        /// A structure is a value type so it is stored on the stack, but a class is a reference type and is stored on 
        /// the heap. A structure doesn't support inheritance, and polymorphism, but a class supports both. By default, 
        /// all the struct members are public but class members are by default private in nature
        /// </summary>
        public void struct_exmaple()
        {
            code_styles c_sharp_code_style;
            c_sharp_code_style.id = "dfsmk3343";
            c_sharp_code_style.style = "awesome";
            c_sharp_code_style.version = "1.0v";
            
            Console.WriteLine(c_sharp_code_style.style);
        }

        public void calcualte_fractorial(int number)
        {
            int sum = 1;
            
            for (int counter = 0; counter < number; counter++)
            {
                var tempCount = counter + 1;
                sum = tempCount * sum;
            }

            Console.WriteLine("Fractorial of {0} is {1}", number, sum);
        }

        public void ready_file_and_sort(string file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(file_path);

            Console.WriteLine(lines[0]);
            
            
        }
    }
}