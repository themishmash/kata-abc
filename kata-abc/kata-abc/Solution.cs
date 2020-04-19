using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_abc
{
    public class kata_abc
    {
        public static void Solution()
        {
            
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
            string userInput = Console.ReadLine().ToUpper();
           //string userInput = "bark";
           

           Console.WriteLine(userInput);

            
            // foreach (char letter in userInput)
            // {
            //     Console.WriteLine(letter);
            // }

            //Console.WriteLine(userInput);
            
            //clone list
           List<string> clonedList = new List<string>(blocks);
            
            //empty list of blocks
            List<string> ListOfUsedBlocks = new List<string>();
            
            
            
            foreach(char letter in userInput)
            {
                
                var itemToRemove = blocks.FirstOrDefault(item => item.Contains(letter));
                
                ListOfUsedBlocks.Add(itemToRemove);
                blocks.Remove(itemToRemove);
              
                 
                    
            }
            
            
            // foreach(char letter in userInput)
            // foreach (string pair in clonedList)
            // {
            //     
            //     if (pair.Contains(letter))
            //         
            //         ListOfUsedBlocks.Add(pair);
            //     
            //     
            // }

            // foreach (string item in blocks)
            // {
            //     Console.WriteLine(item);
            // }

            
            foreach (string item in ListOfUsedBlocks)
            {
                Console.WriteLine(item);
            }

            //empty list of user letters 
            //List<char> ListOfUserLetter = new List<char>();
            
            // List<string> DistinctList = ListOfUsedBlocks.Distinct().ToList();
            //
            // DistinctList.RemoveAll(item => item == null);
            //
            // foreach (string item in DistinctList)
            // {
            //     
            //     Console.WriteLine(item);
            // }

            
            ListOfUsedBlocks.RemoveAll(item => item == null);
            Console.WriteLine(ListOfUsedBlocks.Count);

            // Console.WriteLine(DistinctList.Count);
            //
            if (ListOfUsedBlocks.Count == userInput.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            







            // List<string> DistinctList = ListOfWord.Distinct().ToList();
            //
            // // foreach (string value in DistinctList)
            // // {
            // //     Console.WriteLine(value);
            // // }
            //
            //  List<char> userCharacter = new List<char>();
            //
            //  foreach (char item in userInput)
            //  {
            //      userCharacter.Add(item);
            //  }
            //
            //
            //      
            //
            // if (DistinctList.Count >= userInput.Length)
            // {
            //     Console.WriteLine("true");
            // }
            // else
            // {
            //     Console.WriteLine("false");
            // }





        }
           
            
        }

           
                
        

}