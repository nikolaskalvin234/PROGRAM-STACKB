using System;

namespace Program_Stack_B
{
    class Program
    {
        public static char[] tumpukan = new char[10]; 
        public static char top_s;
        public static int top_index;
        static void Main(string[] args)
        {
            int menu = 0; ;
            do
            {
                Console.Clear();
                Console.WriteLine("STACK");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Push");
                Console.WriteLine("3. Pop");
                Console.WriteLine("4. Display Top Elmen");
                Console.WriteLine("5. Display NOEL");
                Console.WriteLine("0. Exit");
                Console.Write("\nPiih menu:"); 
                menu = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Create" );
                        top_index = 0;
                        Console.ReadKey();
                        break;
                    case 2:
                        
                        Console.WriteLine("Elmen yang akan ditambahkan? ");
                        char elment_e= char.Parse(Console.ReadKey().KeyChar.ToString());
                        PUSH(elment_e);
                        
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Pop");
                        POP();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Display Top Elmen");
                        Console.WriteLine("Top Elmen: "+TOP(tumpukan));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Display NOEL");
                        Console.WriteLine(NOEL());
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
            
           
            // daftar modul
            void CREATE(params char[] S)
            {
            }
            void PUSH(char elment_e)
            {
                tumpukan[top_index] = elment_e;
                top_index++;
            }
            void POP()
            {
                if (top_index > 0) top_index= top_index-1;
            }
            char TOP(char[] S)
            {
                tampilkanElmenTumpukan();
                return S[top_index - 1];
            }
            int NOEL()
            {
                int noel = top_index;
                return noel;
            }
            bool ISEMPTY(char[] S)
            {
                if (top_index == 0)
                    return true;
                else return false;
            }
            void tampilkanElmenTumpukan()
            {
                Console.WriteLine("Display Elment");
                for (int i = 0; i <= top_index; i++) Console.Write("\t" + tumpukan[i]);
                Console.WriteLine("\n");
            }
        }
    }
}
