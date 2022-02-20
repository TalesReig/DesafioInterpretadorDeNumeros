using System;
using System.IO;

namespace InterpretadorDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string combinacao1="", combinacao2="", combinacao3="";
            string entrada = @"\n
     __  __  __  __      __  __     
   ||__    ||__||__|   | __| __||__|
   ||__|   ||__| __|   ||__  __|   |

 __      __  __      __  __  __  __ 
 __||__|   ||__|   | __||__ |__ |__|
 __|   |   ||__|   ||__  __||__| __|

 __  __  __  __  __      __  __     
 __| __||__ |__ |__||__|   ||__|   |
 __||__  __||__| __|   |   ||__|   |

 __  __  __  __  __  __      __     
|  | __||__ |__    ||__|   ||__||__|
|__||__  __||__|   ||__|   | __|   |
            ";

            StringReader linhas = new StringReader(entrada);
            linhas.ReadLine();

            Console.WriteLine("Entrada:");

            string linha1= linhas.ReadLine();
            Console.WriteLine(linha1);
            string linha2 = linhas.ReadLine();
            Console.WriteLine(linha2);
            string linha3 = linhas.ReadLine();
            Console.WriteLine(linha3);
            linhas.ReadLine();

            string linha4 = linhas.ReadLine();
            Console.WriteLine(linha4);
            string linha5 = linhas.ReadLine();
            Console.WriteLine(linha5);
            string linha6 = linhas.ReadLine();
            Console.WriteLine(linha6);
            linhas.ReadLine();

            string linha7 = linhas.ReadLine();
            Console.WriteLine(linha7);
            string linha8 = linhas.ReadLine();
            Console.WriteLine(linha8);
            string linha9 = linhas.ReadLine();
            Console.WriteLine(linha9);
            linhas.ReadLine();

            string linha10 = linhas.ReadLine();
            Console.WriteLine(linha10);
            string linha11 = linhas.ReadLine();
            Console.WriteLine(linha11);
            string linha12 = linhas.ReadLine();
            Console.WriteLine(linha12);
            linhas.ReadLine();

            Console.WriteLine("\n------------------------------------------------------------");

            char[] primeiroChar = linha1.ToCharArray();
            char[] segundoChar = linha2.ToCharArray();
            char[] terceiroChar = linha3.ToCharArray();
            char[] quartoChar = linha4.ToCharArray();
            char[] quintoChar = linha5.ToCharArray();
            char[] sextoChar = linha6.ToCharArray();
            char[] setimoChar = linha7.ToCharArray();
            char[] oitavoChar = linha8.ToCharArray();
            char[] nonoChar = linha9.ToCharArray();
            char[] decimoChar = linha10.ToCharArray();
            char[] decimoprimeiroChar = linha11.ToCharArray();
            char[] decimosegundoChar = linha12.ToCharArray();

            Console.WriteLine("\r\nSaída:");

            Console.WriteLine();
            Console.WriteLine();

            //Linha1
            for (int i = 0; i < primeiroChar.Length ; i++)
            {
                combinacao1 = combinacao1+ primeiroChar[i];
                combinacao2 = combinacao2 + segundoChar[i];
                combinacao3 = combinacao3 + terceiroChar[i];

                if (combinacao1 == " __ " && combinacao2 == "|  |" && combinacao3 == "|__|")//0
                {
                    Console.Write("0");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 =="   |" && combinacao3 == "   |")//1
                {
                    Console.Write("1");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if(combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == "|__ ")//2
                {
                    Console.Write("2");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == " __|")//3
                {
                    Console.Write("3");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "|__|" && combinacao3 == "   |")//4
                {
                    Console.Write("4");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == " __|")//5
                {
                    Console.Write("5");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == "|__|")//6
                {
                    Console.Write("6");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "   |" && combinacao3 == "   |")//7
                {
                    Console.Write("7");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == "|__|")//8
                {
                    Console.Write("8");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == " __|")//9
                {
                    Console.Write("9");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
            }

            Console.WriteLine();
            //linha2

            for (int j = 0; j < quartoChar.Length; j++)
            {
                combinacao1 = combinacao1 + quartoChar[j];
                combinacao2 = combinacao2 + quintoChar[j];
                combinacao3 = combinacao3 + sextoChar[j];

                if (combinacao1 == " __ " && combinacao2 == "|  |" && combinacao3 == "|__|")//0
                {
                    Console.Write("0");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "   |" && combinacao3 == "   |")//1
                {
                    Console.Write("1");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == "|__ ")//2
                {
                    Console.Write("2");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == " __|")//3
                {
                    Console.Write("3");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "|__|" && combinacao3 == "   |")//4
                {
                    Console.Write("4");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == " __|")//5
                {
                    Console.Write("5");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == "|__|")//6
                {
                    Console.Write("6");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "   |" && combinacao3 == "   |")//7
                {
                    Console.Write("7");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == "|__|")//8
                {
                    Console.Write("8");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == " __|")//9
                {
                    Console.Write("9");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
            }

            Console.WriteLine();
            //linha3

            for (int j = 0; j < oitavoChar.Length; j++)
            {
                combinacao1 = combinacao1 + setimoChar[j];
                combinacao2 = combinacao2 + oitavoChar[j];
                combinacao3 = combinacao3 + nonoChar[j];

                if (combinacao1 == " __ " && combinacao2 == "|  |" && combinacao3 == "|__|")//0
                {
                    Console.Write("0");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "   |" && combinacao3 == "   |")//1
                {
                    Console.Write("1");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == "|__ ")//2
                {
                    Console.Write("2");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == " __|")//3
                {
                    Console.Write("3");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "|__|" && combinacao3 == "   |")//4
                {
                    Console.Write("4");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == " __|")//5
                {
                    Console.Write("5");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == "|__|")//6
                {
                    Console.Write("6");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "   |" && combinacao3 == "   |")//7
                {
                    Console.Write("7");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == "|__|")//8
                {
                    Console.Write("8");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == " __|")//9
                {
                    Console.Write("9");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
            }

            Console.WriteLine();
            //linha4

            for (int j = 0; j < decimoChar.Length; j++)
            {
                combinacao1 = combinacao1 + decimoChar[j];
                combinacao2 = combinacao2 + decimoprimeiroChar[j];
                combinacao3 = combinacao3 + decimosegundoChar[j];

                if (combinacao1 == " __ " && combinacao2 == "|  |" && combinacao3 == "|__|")//0
                {
                    Console.Write("0");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "   |" && combinacao3 == "   |")//1
                {
                    Console.Write("1");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == "|__ ")//2
                {
                    Console.Write("2");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == " __|" && combinacao3 == " __|")//3
                {
                    Console.Write("3");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == "    " && combinacao2 == "|__|" && combinacao3 == "   |")//4
                {
                    Console.Write("4");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == " __|")//5
                {
                    Console.Write("5");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__ " && combinacao3 == "|__|")//6
                {
                    Console.Write("6");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "   |" && combinacao3 == "   |")//7
                {
                    Console.Write("7");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == "|__|")//8
                {
                    Console.Write("8");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
                if (combinacao1 == " __ " && combinacao2 == "|__|" && combinacao3 == " __|")//9
                {
                    Console.Write("9");
                    combinacao1 = "";
                    combinacao2 = "";
                    combinacao3 = "";
                }
            }
            Console.WriteLine();
            Console.WriteLine(); 

        }
    }
}
