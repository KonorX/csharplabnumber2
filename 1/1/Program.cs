using System;

namespace _1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            char[] b= new char[] { ' ',' ',' ',' ' } ;
            Random pos = new Random();
            Console.WriteLine("генерирую строку из 4 английских строчных букв");
            int i = 0;
            while (i <= 3)
            {
                
                int pos4 = pos.Next(1, 26);
                switch (pos4)
                {
                    case 1:
                        b[i] = 'a';
                        break;
                    case 2:
                        b[i] = 'b';
                        break;
                    case 3:
                        b[i] = 'c';
                        break;
                    case 4:
                        b[i] = 'd';
                        break;
                    case 5:
                        b[i] = 'e';
                        break;
                    case 6:
                        b[i] = 'f';
                        break;
                    case 7:
                        b[i] = 'g';
                        break;
                    case 8:
                        b[i] = 'h';
                        break;
                    case 9:
                        b[i] = 'i';
                        break;
                    case 10:
                        b[i] = 'j';
                        break;
                    case 11:
                        b[i] = 'k';
                        break;
                    case 12:
                        b[i] = 'l';
                        break;
                    case 13:
                        b[i] = 'm';
                        break;
                    case 14:
                        b[i] = 'n';
                        break;
                    case 15:
                        b[i] = 'o';
                        break;
                    case 16:
                        b[i] = 'p';
                        break;
                    case 17:
                        b[i] = 'q';
                        break;
                    case 18:
                        b[i] = 'r';
                        break;
                    case 19:
                        b[i] = 's';
                        break;
                    case 20:
                        b[i] = 't';
                        break;
                    case 21:
                        b[i] = 'u';
                        break;
                    case 22:
                        b[i] = 'v';
                        break;
                    case 23:
                        b[i] = 'w';
                        break;
                    case 24:
                        b[i] = 'x';
                        break;
                    case 25:
                        b[i] = 'y';
                        break;
                    case 26:
                        b[i] = 'z';
                        break;
                    default:
                        Console.WriteLine("error");
                        break ;
                }
                i++;

            }
            Console.WriteLine("the combination is");
            Console.Write(b[0]);
            Random vyvod = new Random();
            
            int intv1 = vyvod.Next(0, 50);
            if (intv1>=25)
            {
                Console.Write(b[1]);
            }
            int intv2 = vyvod.Next(0, 50);
            if (intv2>=25)
            {
                Console.Write(b[2]);
            }
            int intv3 = vyvod.Next(0, 50);
            if (intv3 >= 25)
            {
                Console.Write(b[3]);
            }

        }
    }
}
