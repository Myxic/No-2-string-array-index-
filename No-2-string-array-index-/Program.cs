// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Generic;
using System.Linq;



var list1 = new List<int>() { };

Console.Write("Enter Words  ");
var strings = Console.ReadLine();

for (int i = 0; i < strings.Length; i++)
{
    char letter = strings[i];

    //char letter1 = letter.TO
    if (char.IsUpper(letter))
    {
        int indexxx = strings.IndexOf(letter);
        
        list1.Add(indexxx);
        Console.WriteLine($"{letter } in the index {indexxx}");
    }
    //Console.WriteLine(list1);
};

