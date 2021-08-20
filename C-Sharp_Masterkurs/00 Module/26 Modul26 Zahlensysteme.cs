using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace C_Sharp_Masterkurs.Module
{
    public class Modul26
    {
        public Modul26()
        {
        }
        public void Zahlensysteme()
        {
--------------------------------------------------------------------------------

            //Taschenrechner umstellen auf Programmierer

--------------------------------------------------------------------------------

//Dezimal in Dual
73 in Dual

            73  /   2   =   36  R1 /|\                                          R = Rest
            36  /   2   =   18  R0  |
            18  /   2   =   9   R0  |    
            9   /   2   =   4   R1  |
            4   /   2   =   2   R0  |
            2   /   2   =   1   R0  |   2/2 = 1 NICHT das Ende, da Ergebniss = 0 sein muss
            1   /   2   =   0   R1  |   von unten nach oben lesen

            => 73 = 100 1001

--------------------------------------------------------------------------------

//Dual in Dezimal
100110 in Dezimal

            Dual in Dezimal wird von hinten nach vorne berechnet 100110 = 011001

            0*2^0 + 1*2^1 + 1*2^2 + 0*2^3 + 0*2^4 + 1*2^5                       ^ = darauffolgende Zahl ist Hochzahl
            
            = 38

            => 100 110 = 38

--------------------------------------------------------------------------------

//Hexadezimalzahl in Dual
FC3 in Dual
            Jeder Buchstabe bzw. jede Zahl der Hexadezimalzahl steht für einen 4er Block in der Dualzahl

    A = 10
    B = 11
    C = 12
    D = 13
    E = 14           2^3  2^2  2^1  2^0 |   2^3  2^2  2^1  2^0 |   2^3  2^2  2^1  2^0
    F = 15           |    |    |    |   |   |    |    |    |   |   |    |    |    |
                     8    4    2    1   |   8    4    2    1   |   8    4    2    1
            => FC3 = 1    1    1    1   |   1    1    0    0   |   0    0    1    1
                      (8+4+2+1 = 15)      (8+4 = 12)                        (2+1 = 3)
          
--------------------------------------------------------------------------------

//Dual in Hexadezimalzahl
1010 0111 1000 in Hex
            Jeder 4er Block der Dualzahl steht für ein zeichen der Hexadezimalzahl

    A = 10
    B = 11
    C = 12
    D = 13
    E = 14           2^3  2^2  2^1  2^0 |   2^3  2^2  2^1  2^0 |   2^3  2^2  2^1  2^0
    F = 15           |    |    |    |   |   |    |    |    |   |   |    |    |    |
                     8    4    2    1   |   8    4    2    1   |   8    4    2    1
                =>   1    0    1    0   |   0    1    1    1   |   1    0    0    0
                      (8+2 = 10 = A)           (4+2+1 = 7 = 7)    (8 = 8 = 8)            => A78

--------------------------------------------------------------------------------

//Hexadezimalzahl in Dezimal
23D in Dezimal
                    D*16^0   +   3*16^1   +   2*16^2
                    =573
                    => 23D = 573

--------------------------------------------------------------------------------

//Dezimalzahl in Hexadezimalzahl
155 in Hexadezimalzahl

            155 /   16  =   9   R11 = 11 = B
            9   /   16  =   0   R9  =  9 = 9

                                => 155 = 9B

--------------------------------------------------------------------------------

//Bits Bytes und Wertezustand

                    2^7  2^6  2^5  2^4  2^3  2^2  2^1  2^0

                    128   64   32   16    8    4    2    1

                      0    0    1    0    0    0    0    1 

--------------------------------------------------------------------------------
        }
    }
}
*/