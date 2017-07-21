using System;

namespace HelloDotNetCore
{
    public class Machine
    {
        protected string name = "";
        protected int id = 0;
    }

    public class Robot : Machine
    {
        //Constructor syntax
        public Robot(string r_name, int r_id)
        {
            this.name = r_name;
            this.id = r_id;
        }
         
        public string motto { get; set; }
        
        private int fire_power = 5;
     
        public void SpriFire()
        {
            for (int i = 0; i < this.fire_power; i++)
            {
                Console.Write("->");
            }
        }
    }
}