using System;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // .. | -- .- -.. . |  -.-- --- ..- | .-- .-. .. - . | .- | .-.. --- -. --. | -.-. --- -.. .
            StringBuilder sb = new StringBuilder();
            foreach (var element in text)
            {
                if (element != " ")
                {
                    if (element == ".-")
                    {
                        sb.Append("A");
                    }
                    else if (element == "|")
                    {
                        sb.Append(" ");
                    }
                    else if (element == "-...")
                    {
                        sb.Append("B");
                    }
                    else if (element == "-.-.")
                    {
                        sb.Append("C");
                    }
                    else if (element == "-..")
                    {
                        sb.Append("D");
                    }
                    else if (element == ".")
                    {
                        sb.Append("E");
                    }
                    else if (element == "..-.")
                    {
                        sb.Append("F");
                    }
                    else if (element == "--.")
                    {
                        sb.Append("G");
                    }
                    else if (element == "....")
                    {
                        sb.Append("H");
                    }
                    else if (element == "..")
                    {
                        sb.Append("I");
                    }
                    else if (element == ".---")
                    {
                        sb.Append("J");
                    }
                    else if (element == "-.-")
                    {
                        sb.Append("K");
                    }
                    else if (element == ".-..")
                    {
                        sb.Append("L");
                    }
                    else if (element == "--")
                    {
                        sb.Append("M");
                    }
                    else if (element == "-.")
                    {
                        sb.Append("N");
                    }
                    else if (element == "---")
                    {
                        sb.Append("O");
                    }
                    else if (element == ".--.")
                    {
                        sb.Append("P");
                    }
                    else if (element == "--.-")
                    {
                        sb.Append("Q");
                    }
                    else if (element == ".-.")
                    {
                        sb.Append("R");
                    }
                    else if (element == "...")
                    {
                        sb.Append("S");
                    }
                    else if (element == "-")
                    {
                        sb.Append("T");
                    }
                    else if (element == "..-")
                    {
                        sb.Append("U");
                    }
                    else if (element == "...-")
                    {
                        sb.Append("V");
                    }
                    else if (element == ".--")
                    {
                        sb.Append("W");
                    }
                    else if (element == "-..-")
                    {
                        sb.Append("X");
                    }
                    else if (element == "-.--")
                    {
                        sb.Append("Y");
                    }
                    else if (element == "--..")
                    {
                        sb.Append("Z");
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
