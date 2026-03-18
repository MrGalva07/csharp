using System;

class Program
{
    
    static void Main(string[]args){
        Console.Write("Oi,maxu");
        if(args.GetLength(0)>0 )  {
            Console.Write(args.GetValue(0));
        }
        else
        {
            Console.Write("Falta um parametro");
        }
        
    }
};