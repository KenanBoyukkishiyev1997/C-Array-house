using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mertebeni elave ele");
            int floor = int.Parse(Console.ReadLine());

            Console.WriteLine("otag elave ele");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("sahibleri elave ele");
            string[,] people =new string[floor, room] ;

            

            for (int floos = 0; floos < floor; floos++)
            {
                for (int i = 0; i < room; i++)
                {
                  
                    
                        Console.WriteLine($"{floos + 1} -ci mertebenin otag: {i + 1} ");
                          people[floos, i] = Console.ReadLine();
                    
                    
                }
            }

            for (int floos = 0; floos < floor; floos++)
            {
                for (int i = 0; i < room; i++)
                {


                    Console.WriteLine($"{floos + 1} -ci mertebenin otag: {i + 1} sexsler {people[floos,i]} ");
                    


                }
            }






        }

        
    }










}
