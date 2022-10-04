using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class Morza
    {
        string m, s;
        public void TranslateTo(string a)
        {
            m = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'A')
                    m += ".- ";
                else if (a[i] == 'b' || a[i] == 'B')
                    m += "-... ";
                else if (a[i] == 'c' || a[i] == 'C')
                    m += "-.-. ";
                else if (a[i] == 'd' || a[i] == 'D')
                    m += "-.. ";
                else if (a[i] == 'e' || a[i] == 'E')
                    m += ". ";
                else if (a[i] == 'f' || a[i] == 'F')
                    m += "..-. ";
                else if (a[i] == 'g' || a[i] == 'G')
                    m += "--. ";
                else if (a[i] == 'h' || a[i] == 'H')
                    m += ".... ";
                else if (a[i] == 'i' || a[i] == 'I')
                    m += ".. ";
                else if (a[i] == 'j' || a[i] == 'J')
                    m += ".--- ";
                else if (a[i] == 'k' || a[i] == 'K')
                    m += "-.- ";
                else if (a[i] == 'l' || a[i] == 'L')
                    m += ".-.. ";
                else if (a[i] == 'm' || a[i] == 'M')
                    m += "-- ";
                else if (a[i] == 'n' || a[i] == 'N')
                    m += "-. ";
                else if (a[i] == 'o' || a[i] == 'O')
                    m += "--- ";
                else if (a[i] == 'p' || a[i] == 'P')
                    m += ".--. ";
                else if (a[i] == 'q' || a[i] == 'Q')
                    m += "--.- ";
                else if (a[i] == 'r' || a[i] == 'R')
                    m += ".-. ";
                else if (a[i] == 's' || a[i] == 'S')
                    m += "... ";
                else if (a[i] == 't' || a[i] == 'T')
                    m += "- ";
                else if (a[i] == 'u' || a[i] == 'U')
                    m += "..- ";
                else if (a[i] == 'v' || a[i] == 'V')
                    m += "...- ";
                else if (a[i] == 'w' || a[i] == 'W')
                    m += ".-- ";
                else if (a[i] == 'x' || a[i] == 'X')
                    m += "-..- ";
                else if (a[i] == 'y' || a[i] == 'Y')
                    m += "-.-- ";
                else if (a[i] == 'z' || a[i] == 'Z')
                    m += "--..";
                else if (a[i] == ' ')
                    m += "/ ";
            }
        }
        public void TranslateFrom()
        {
            string l = "";
            s = "";
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != ' ')
                    l += m[i];
                else
                {
                    if (l == ".-")
                        s += "a";
                    else if (l == "-...")
                        s += "b";
                    else if (l == "-.-.")
                        s += "c";
                    else if (l == "-..")
                        s += "d";
                    else if (l == ".")
                        s += "e";
                    else if (l == "..-.")
                        s += "f";
                    else if (l == "--.")
                        s += "g";
                    else if (l == "....")
                        s += "h";
                    else if (l == "..")
                        s += "i";
                    else if (l == ".---")
                        s += "j";
                    else if (l == "-.-")
                        s += "k";
                    else if (l == ".-..")
                        s += "l";
                    else if (l == "--")
                        s += "m";
                    else if (l == "-.")
                        s += "n";
                    else if (l == "---")
                        s += "o";
                    else if (l == ".--.")
                        s += "p";
                    else if (l == "--.-")
                        s += "q";
                    else if (l == ".-.")
                        s += "r";
                    else if (l == "...")
                        s += "s";
                    else if (l == "-")
                        s += "t";
                    else if (l == "..-")
                        s += "u";
                    else if (l == "...-")
                        s += "v";
                    else if (l == ".--")
                        s += "w";
                    else if (l == "-..-")
                        s += "x";
                    else if (l == "-.--")
                        s += "y";
                    else if (l == "--..")
                        s += "z";
                    else if (l == "/")
                        s += " ";
                    l = "";
                }
            }
        }
        public void Print()
        {
            Console.WriteLine(m);
        }
        public void PrintText()
        {
            Console.WriteLine(s);
        }
    }
}