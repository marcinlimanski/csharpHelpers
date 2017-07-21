using System;
using System.Collections.Generic;
using static HelloDotNetCore.Helpers;
using static HelloDotNetCore.Machine;

namespace HelloDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class example   
            Robot tomToRobot = new Robot("tomTo", 6342);
            tomToRobot.motto = "Fuck yea man";
            Console.WriteLine(tomToRobot.motto);
            tomToRobot.SpriFire();
            
            //Generic Helpers example
            Helpers helpers = new Helpers();
            helpers.max_size_of_data_type();
            helpers.explicit_type_conversion();
            helpers.inline_conditional_operators();
            helpers.for_loops();
            helpers.nullables();
            helpers.array_examples();
            helpers.struct_exmaple();
        }
    }
}