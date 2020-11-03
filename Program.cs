using System;

namespace DLTP_Phase1_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ware = new string[30];
            int insertPos = 0;
            bool endProgram = false;
            Console.WriteLine("Hej och välkommen till notan!\nSkriv 'sluta' för att avsluta!");
            while (!endProgram)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "sluta")
                {
                    endProgram = true;
                }
                else if (userInput == "ny")
                {
                    Console.Write("Ange vara: ");
                    string newProduct = Console.ReadLine().ToLower();
                    ware[insertPos] = newProduct;
                    insertPos++;
                    Console.WriteLine($"{newProduct} tillagt!");
                }
                else if (userInput == "visa")
                {
                    for (int i = 0; i < insertPos; i++)
                    {
                        Console.WriteLine($"{i + 1}: {ware[i]}");
                    }
                }
                else if (userInput == "ta bort")
                {
                    Console.Write("Vilket nummer vill du ta bort?: ");
                    int removeProduct = int.Parse(Console.ReadLine());
                    string removed = ware[removeProduct - 1];
                    ware[removeProduct - 1] = "";
                    Console.WriteLine($"{removed} togs bort");
                }
            }
            Console.WriteLine("Adjö!");
        }
    }
}
