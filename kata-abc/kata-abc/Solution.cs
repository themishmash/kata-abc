using System;
using System.Collections.Generic;

namespace kata_abc
{
    public class kata_abc
    {
        public static void Solution()
        {
            var blockList = new List<Tuple<string, string>>
                //Tuple<string, string>[] blockList =
                {
                    Tuple.Create("B", "O"),
                    Tuple.Create("X", "K"),
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
                };
            
            Console.WriteLine(blockList.Count);
        }
    }
}