using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_abc
{
    public class kata_abc
    {
        public static void Solution()
        {

            //var blockList = new List<Tuple<string, string>>
                //Tuple<string, string>[] blockList =
                //{
                    //Tuple.Create("B","O"),
                   // Tuple.Create("X","K"),
/*
                    Tuple.Create("D", "Q"),
                    Tuple.Create("C", "P"),
                    Tuple.Create("N", "A"),
                    Tuple.Create("G", "T"),
                    Tuple.Create("R", "E"),
                    Tuple.Create("T", "G"),
                    Tuple.Create("Q", "D"),
                    Tuple.Create("F", "S"),
                    Tuple.Create("J", "W"),
                    Tuple.Create("H", "U"),
                    Tuple.Create("V", "I"),
                    Tuple.Create("A", "N"),
                    Tuple.Create("O", "B"),
                    Tuple.Create("E", "R"),
                    Tuple.Create("F", "S"),
                    Tuple.Create("L", "Y"),
                    Tuple.Create("P", "C"),
                    Tuple.Create("Z", "M"),
*/
               // };
            
           // Console.WriteLine(blockList.Count);

			List<string> blocks = new List<string>();
					blocks.Add("BO");
                   	blocks.Add("XK");
                   	blocks.Add("DQ");
                    blocks.Add("CP");
                    blocks.Add("NA");
                    blocks.Add("GT");
                    blocks.Add("RE");
                    blocks.Add("TG");
                    blocks.Add("QD");
                    blocks.Add("FS");
                    blocks.Add("JW");
                    blocks.Add("HU");
                    blocks.Add("VI");
                    blocks.Add("AN");
                    blocks.Add("OB");
                    blocks.Add("ER");
                    blocks.Add("FS");
                    blocks.Add("LY");
                    blocks.Add("PC");
                    blocks.Add("ZM");

			       
            
            Console.WriteLine("What word are you trying to make?");
            var userInput = Console.ReadLine().ToUpper();

            foreach (string block in blocks)
            {
                if (block.Contains(userInput))
                {
                  
                    Console.WriteLine(block);
                }
                
            }
            





        }
            //Console.WriteLine(blockList);

            
                
        
    }
}