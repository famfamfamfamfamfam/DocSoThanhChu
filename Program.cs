using System;
namespace SUDUNGSWITCHCASE
{
    class DocSoThanhChu
    {
        static void Main(string[] args)
        {
            int socandoc;
            string donvi = "";
            string chuc = "";
            string tram = "";

            Console.WriteLine("Nhap so can doc:");
            socandoc=int.Parse(Console.ReadLine());

            int sotram = socandoc / 100;
            int hangchuc = socandoc % 100;
            int hangchuc1 = hangchuc / 10;
            int sodonvi = hangchuc % 10;

            if (socandoc==0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (socandoc > 999 || socandoc < 0)
            {
                Console.WriteLine("out of ability");
                return;
            }
            switch (sotram)
            {
                case 0 :
	                tram = "";
                    break;
                case 1:
                    tram = "one";
                    break;
                case 2:
                    tram = "two";
                    break;
                case 3:
                    tram = "three";
                    break;
                case 4:
                    tram = "four";
                    break;
                case 5:
                    tram = "five";
                    break;
                case 6:
                    tram = "six";
                    break;
                case 7:
                    tram = "seven";
                    break;
                case 8:
                    tram = "eight";
                    break;
                case 9:
                    tram = "nine";
                    break;
            }       
            if (sotram != 0)
            {
                tram = tram + " hundred";
            }
            if (hangchuc == 0)
            {
                Console.WriteLine(tram);
            }
            else
            {
                switch (hangchuc1)
                {
                    case 0:
                        chuc = "";
                        break;
                    case 2:
                        chuc = "twen";
                        break;
                    case 3:
                        chuc = "thir";
                        break;
                    case 4:
                        chuc = "for";
                        break;
                    case 5:
                        chuc = "fif";
                        break;
                    case 6:
                        chuc = "six";
                        break;
                    case 7:
                        chuc = "seven";
                        break;
                    case 8:
                        chuc = "eigh";
                        break;
                    case 9:
                        chuc = "nine";
                        break;
                }
                if (hangchuc1 != 0)
                {
                    chuc = chuc + "ty";
                }
                if (hangchuc1 == 1)
                {
                    switch (sodonvi)
                    {
                        case 0:
                            chuc = "ten";
                            break;
                        case 1:
                            chuc = "eleven";
                            break;
                        case 2:
                            chuc = "twelve";
                            break;
                        case 3:
                            chuc = "thir";
                            break;
                        case 4:
                            chuc = "four";
                            break;
                        case 5:
                            chuc = "fif";
                            break;
                        case 6:
                            chuc = "six";
                            break;
                        case 7:
                            chuc = "seven";
                            break;
                        case 8:
                            chuc = "eigh";
                            break;
                        case 9:
                            chuc = "nine";
                            break;
                    }
                    if (sodonvi > 2)
                    {
                        chuc = chuc + "teen";
                    }
                }
                if (sodonvi == 0)
                {
                    Console.WriteLine((tram + " " + chuc).Trim());
                }
                else
                {
                    switch (sodonvi)
                    {
                        case 1:
                            donvi = "one";
                            break;
                        case 2:
                            donvi = "two";
                            break;
                        case 3:
                            donvi = "three";
                            break;
                        case 4:
                            donvi = "four";
                            break;
                        case 5:
                            donvi = "five";
                            break;
                        case 6:
                            donvi = "six";
                            break;
                        case 7:
                            donvi = "seven";
                            break;
                        case 8:
                            donvi = "eight";
                            break;
                        case 9:
                            donvi = "nine";
                            break;
                    }
                    if (hangchuc1 == 1)
                    {
                        Console.WriteLine((tram + " " + chuc).Trim());
                    }
                    else Console.WriteLine((tram + " " + chuc + " " + donvi).Trim());
                }
            }
        }
    }
}