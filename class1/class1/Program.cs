using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];
            for (int i = 0; i < 5; i++)
            {
                Animal A1 = new Animal();
                Console.WriteLine("enter the animal type:");
                A1.Type = Console.ReadLine();
                Console.WriteLine("enter the animal name:");
                A1.Name = Console.ReadLine();
                Console.WriteLine("enter the animal age:");
                A1.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the animal ID:");
                A1.ID = int.Parse(Console.ReadLine());
                Console.WriteLine(A1.Display());
                animals[i] = A1;
            }
        }
    }
    class  Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
         
        public string Display()
        {
            return $"....Animal Details...\nType= {Type}\n Name= {Name}\n Age= {Age}\n ID = {ID}"; 
             
            }
         
        
    }
}
