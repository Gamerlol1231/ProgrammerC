using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_in_one_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool avsluta = true;
            while (avsluta)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("**  [1] Phytaguras            **");
                Console.WriteLine("**  [2] Betyg                 **");
                Console.WriteLine("**  [3] cirkelArea            **");
                Console.WriteLine("**  [4] RektangelArea         **");
                Console.WriteLine("**  [5] Två Mynt Random       **");
                Console.WriteLine("**  [6] Sek till H,Min,Sek    **");
                Console.WriteLine("**  [7] Barn                  **");
                Console.WriteLine("**  [8] udda/jämna tal        **");
                Console.WriteLine("**  [9] positivt/negativt     **");
                Console.WriteLine("** [10] Kasta tre tärningar   **");
                Console.WriteLine("** [11] Fuktion Cos           **");
                Console.WriteLine("** [12] Andragradsekvation    **");
                Console.WriteLine("** [13] F till C              **");
                Console.WriteLine("** [14] P-q Formel            **");
                Console.WriteLine("** [15] talen/olika           **");
                Console.WriteLine("** [16] fråga namn            **");
                Console.WriteLine("** [17] Koordinat             **");
                Console.WriteLine("** [18] F(x) = √x^2+y^2       **");
                Console.WriteLine("** [19] F(x) = x^2 + 2x +3    **");
                Console.WriteLine("** [20] Gissa spel {extra}    **");
                Console.WriteLine("** avsluta meny skriv  break  **");
                Console.WriteLine("*******************************");
                Console.WriteLine("Välj ett tal mellan 1 eller 2");
                string Num = Convert.ToString(Console.ReadLine());

                if (Num == "break")
                {
                    break;
                }

                if (Num == "1")
                {
                    Console.WriteLine("Vilken vill du räkna ut\r\nKatet A[1]\r\nKatet B[2]\r\nHypotenusan[3]\r\nRäkna ut Alla tre[4]");
                    char side = Convert.ToChar(Console.ReadLine());
                    if (side == '1')
                    {
                        Console.WriteLine("Ange Tal till katet B: ");
                        double KatB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ange tal till Hypotenusan: ");
                        double Hypo = Convert.ToDouble(Console.ReadLine());
                        KatB = Math.Pow(KatB, 2);
                        Hypo = Math.Pow(Hypo, 2);
                        double KatA = Math.Sqrt(Hypo - KatB);
                        Console.WriteLine("Katet A = " + Math.Round(KatA, 2));
                        Console.ReadLine();
                    }
                    else if (side == '2')
                    {
                        Console.WriteLine("Ange Tal till katet A: ");
                        double KatA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ange tal till Hypotenusan: ");
                        double Hypo = Convert.ToDouble(Console.ReadLine());
                        KatA = Math.Pow(KatA, 2);
                        Hypo = Math.Pow(Hypo, 2);
                        double KatB = Math.Sqrt(Hypo - KatA);
                        Console.WriteLine("Katet B = " + Math.Round(KatB, 2));
                        Console.ReadLine();
                    }
                    else if (side == '3')
                    {
                        Console.Write("Ange Tal till Katet A: ");
                        double aKatet = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ange Tal till Katet B: ");
                        double bKatet = Convert.ToDouble(Console.ReadLine());
                        double akatetKvadrat = Math.Pow(aKatet, 2);
                        double bkatetKvadrat = Math.Pow(bKatet, 2);
                        double cHypo = Math.Sqrt(akatetKvadrat + bkatetKvadrat);
                        double cHypo2 = Math.Round(cHypo, 2);
                        Console.WriteLine($"Hypotens är {cHypo2}");
                        Console.ReadLine();
                    }
                    else if (side == '4')
                    {
                        Console.Write("Ange för katet A: ");
                        double aKatet = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ange för katet B: ");
                        double bKatet = Convert.ToDouble(Console.ReadLine());
                        double akatetKvadrat = Math.Pow(aKatet, 2);
                        double bkatetKvadrat = Math.Pow(bKatet, 2);
                        double cHypo = Math.Sqrt(akatetKvadrat + bkatetKvadrat);
                        double cHypo2 = Math.Round(cHypo, 2);
                        Console.WriteLine($"Hypotens är {cHypo2}");
                        Console.ReadLine();
                    }
                }
                else if (Num == "2")
                {
                    Console.WriteLine("Vad heter du: ");
                    String namn = Console.ReadLine();

                    Console.WriteLine("Ange det poänget du fick i provet: ");
                    int betyg = Convert.ToInt32(Console.ReadLine());

                    if (betyg >= 90 && betyg <= 100)
                    {
                        Console.WriteLine("Grattis du klarade provet " + namn + " du fick ett A");
                    }
                    else if (betyg >= 80 && betyg <= 89)
                    {
                        Console.WriteLine("Grattis du klarade provet " + namn + " du fick et B");
                    }
                    else if (betyg >= 70 && betyg <= 79)
                    {
                        Console.WriteLine("Grattis du klarade provet " + namn + " du fick ett C");
                    }
                    else if (betyg >= 60 && betyg <= 69)
                    {
                        Console.WriteLine("Grattis du klarade provet " + namn + " du fick ett C");
                    }
                    else if (betyg >= 50 && betyg <= 59)
                    {
                        Console.WriteLine("Grattis du klarade provet " + namn + " du fick ett C");
                    }
                    else if (betyg <= 49)
                    {
                        Console.WriteLine("Du fick ett F i ditt betyg");
                        Console.WriteLine("Förlåt men du måste göra om provet " + namn);
                    }
                    Console.WriteLine("Du fick " + betyg + " poäng i ditt prov");
                }
                else if (Num == "3")
                {
                    Console.Write("Ange Radie");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double Pi = 3.14;

                    double area = Pi * r * r;
                    double omkrets = 2 * r * Pi;
                    Console.WriteLine("Area = " + area + " cm²");
                    Console.WriteLine("Omkrets = " + omkrets + " cm");
                    Console.ReadLine();
                }
                else if (Num == "4")
                {
                    int basen;
                    int höjden;
                    int area;
                    // int basen, höjden;
                    Console.WriteLine("Ange Basen: ");
                    basen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ange Höjden: ");
                    höjden = Convert.ToInt32(Console.ReadLine());
                    area = basen * höjden;
                    Console.WriteLine("Rektangelsarea = " + area + " cm²");
                    // numlk 0178 för cm²
                    Console.ReadLine();
                }
                else if (Num == "5")
                {
                    Random slump = new Random();

                    //1 = kung
                    //3 = kl
                    int kasta = slump.Next(1, 3);
                    int kasta2 = slump.Next(1, 3);

                    if (kasta + kasta2 == 2)
                    {
                        Console.WriteLine("du får en ballong eftersom du fick kung i båda mynten");
                        Console.WriteLine("             .#############. \r\n          .###################. \r\n       .####%####################.,::;;;;;;;;;;, \r\n      .####%###############%######:::;;;;;;;;;;;;;, \r\n      ####%%################%######:::;;;;;;;;@;;;;;;, \r\n      ####%%################%%#####:::;;;;;;;;;@;;;;;;, \r\n      ####%%################%%#####:::;;;;;;;;;@@;;;;;; \r\n      `####%################%#####:::;;;;;;;;;;@@;;;;;; \r\n        `###%##############%####:::;;;;;;;;;;;;@@;;;;;; \r\n           `#################'::%%%%%%%%%%%%;;;@;;;;;;' \r\n             `#############'.%%%%%%%%%%%%%%%%%%;;;;;' \r\n               `#########'%%%%#%%%%%%%%%%%%%%%%%%%, \r\n                 `#####'.%%%%#%%%%%%%%%%%%%%#%%%%%%, \r\n                   `##' %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                   ###  %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                    '   %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                   '    `%%%%#%%%%%%%%%%%%%%%#%%%%%' \r\n                  '       `%%%#%%%%%%%%%%%%%#%%%%' \r\n                  `         `%%%%%%%%%%%%%%%%%%' \r\n                   `          `%%%%%%%%%%%%%%' \r\n                    `           `%%%%%%%%%%'  ' \r\n                     '            `%%%%%%'   ' \r\n                    '              `%%%'    ' \r\n                   '               .%%      ` \r\n                  `                %%%       ' \r\n                   `                '       ' \r\n                    `              '      ' \r\n                    '            '      ' \r\n                   '           '       ` \r\n                  '           '        ' \r\n                              `       ' \r\n                               ' \r\n                              ' \r\n                             ' \r\n\r\n\r\na@@@@@@@@a  a@@@@@@a  a@@@@@@@a a@@@@@@@@a a@@a.  .a@@a  a@@a \r\n@@@@  @@@@ @@@@  @@@@ @@@@  @@@ @@@@@@@@@@ @@@@a  a@@@@  @@@@ \r\n@@@@  @@@@ @@@@  @@@@ @@@@  @@@    @@@@    `@@@@  @@@@'  @@@@ \r\n@@@@@@@@@@ @@@@@@@@@@ @@@@@@@@'    @@@@      `@@@@@@'    @@@@ \r\n@@@@@@@@@' @@@@@@@@@@ @@@@@@@@a    @@@@        @@@@      `@@' \r\n@@@@       @@@@  @@@@ @@@@ @@@@    @@@@        @@@@ \r\n@@@@       @@@@  @@@@ @@@@ @@@@    @@@@        @@@@       @@");
                    }
                    else if (kasta + kasta2 == 4)
                    {
                        Console.WriteLine("du får en glass eftersom du fick två kl");
                        Console.WriteLine("           ()\r\n        .-\"`'\"-.\r\n       /        \\\r\n       \\        /\r\n       /'---'--`\\\r\n      |          |\r\n      \\_.--.__.-./\r\n      (_.__..__._)\r\n        [=-=-=-]\r\n         |=-=-|\r\n         |-=-=|\r\n    jgs  '-==-'\r\n\r\n------------------------------------------------\r\nThank you for visiting https://asciiart.website/\r\nThis ASCII pic can be found at\r\nhttps://asciiart.website/index.php?art=food%20and%20drink/ice%20cream\r\n");
                    }
                    else
                    {
                        Console.WriteLine("du måste betala 2 kr eftersom du fick olika. du fick en kung och en kl");
                    }
                    Console.ReadKey();
                }
                else if (Num == "6")
                {
                    Console.WriteLine("Välj mellan 1 - 3 finns 3 olika sätt");
                    char se = Convert.ToChar(Console.ReadLine());

                    if (se == '1')
                    {
                        //ett sätt 1 v 3
                        int sek, tim, min;

                        Console.WriteLine("Hur många sekunder vill du omvandla");
                        sek = Convert.ToInt32(Console.ReadLine());

                        tim = sek / 3600;
                        min = sek / 60 % 60;
                        sek = sek % 60;

                        Console.WriteLine($"Sekunder till timmar är {tim}");
                        Console.WriteLine($"Sekunder till minuter är {min}");
                        Console.WriteLine($"Sekunder från timmar och minuter är {sek}");
                        Console.ReadKey();
                    }
                    else if (se == '2')
                    {
                        //en till sätt 2 av 3
                        int H, min, min2, sec, tsec;
                        Console.WriteLine("Hur många sekunder vill du omvandla");
                        tsec = Convert.ToInt32(Console.ReadLine());
                        H = tsec / 3600;
                        min = tsec - (H * 3600);
                        min2 = min / 60;
                        sec = tsec - (H * 3600) - (min2 * 60);
                        Console.WriteLine($"Sekunder till timmar är {H}");
                        Console.WriteLine($"Sekunder till minuter är {min2}");
                        Console.WriteLine($"Sekunder från timmar och minuter är {sec}");
                        Console.ReadKey();
                    }
                    else if (se == '3')
                    {
                        //En till sätt 3 v 3
                        int sek, min, H;
                        Console.WriteLine("Hur många sekunder vill du omvandla");
                        sek = Convert.ToInt32(Console.ReadLine());
                        min = sek / 60;
                        H = min / 60;
                        sek = sek % 60;

                        min = min % 60;

                        Console.WriteLine($"Min är {min}  timmar är {H} och sekunder är {sek}");
                        Console.ReadKey();
                    }
                }
                else if (Num == "7")
                {
                    Console.WriteLine("Ange ditt ålder");
                    int barnÅlder = Convert.ToInt32(Console.ReadLine());

                    if (barnÅlder >= 1 && barnÅlder <= 10)
                    {
                        Console.WriteLine("Du får en Kram");

                    }
                    else if (barnÅlder >= 11 && barnÅlder <= 15)
                    {
                        Console.WriteLine("får du 10 kr");
                    }
                    else if ((barnÅlder >= 16 && barnÅlder <= 20) || (barnÅlder >= 60 && barnÅlder <= 65))
                    {
                        Console.WriteLine("får du 50 kr");
                    }
                    else if ((barnÅlder >= 21 && barnÅlder >= 58))
                    {
                        Console.WriteLine("förlåt du får inget");
                    }
                    Console.ReadKey();
                }
                else if (Num == "8")
                {
                    int tal;
                    Console.WriteLine("Ange ett tal");
                    tal = Convert.ToInt32(Console.ReadLine());

                    if (tal % 2 == 0)
                    {
                        Console.WriteLine("talet är jämnt");
                    }
                    else
                    {
                        Console.WriteLine("talet är udda");
                    }
                    Console.ReadKey();
                }
                else if (Num == "9")
                {
                    double värde1;
                    Console.WriteLine("Ange ett värde: ");
                    värde1 = Convert.ToInt32(Console.ReadLine());

                    if (värde1 > 0)
                    {
                        Console.WriteLine("Värdet är positivt");
                    }
                    else
                    {
                        Console.WriteLine("Värdet är negativt");
                    }
                    Console.ReadKey();
                }
                else if (Num == "10")
                {
                    Random slump = new Random();
                    int tärning1, tärning2, tärning3, maxPoint;

                    tärning1 = slump.Next(1, 7);
                    tärning2 = slump.Next(1, 7);
                    tärning3 = slump.Next(1, 7);

                    maxPoint = 0;


                    if (maxPoint < tärning1) maxPoint = tärning1;
                    if (maxPoint < tärning2) maxPoint = tärning2;
                    if (maxPoint < tärning3) maxPoint = tärning3;

                    Console.WriteLine("Tärning 1 = " + tärning1);
                    Console.WriteLine("Tärning 2 = " + tärning2);
                    Console.WriteLine("Tärning 3 = " + tärning3);
                    Console.WriteLine("MaxPoint = " + maxPoint);
                    Console.ReadKey();
                }
                else if (Num == "11")
                {

                }
                else if (Num == "12")
                {

                }
                else if (Num == "13")
                {
                    Console.WriteLine("[1]C till F\r\n[2]F till C");
                    char som = Convert.ToChar(Console.ReadLine());
                    if (som == '1')
                    {
                        int C;
                        Console.WriteLine("Vad är C");
                        C = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Celcius är " + C + "°");
                        Double F = C * 9 / 5 + 32;
                        Console.WriteLine($"Fahrenheit är {F}°F");
                        Console.ReadKey();
                    }
                    else if (som == '2')
                    {
                        int F;
                        Console.WriteLine("Vad är F");
                        F = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fahrenheit är " + F + "°");
                        Double C = (F - 32) * 5 / 9;
                        Console.WriteLine($"Celcius är {C}°C");
                        Console.ReadKey();
                    }
                }
                else if (Num == "14")
                {
                    Console.WriteLine("Ange A");
                    double A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange B");
                    double B = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange C");
                    double C = Convert.ToDouble(Console.ReadLine());

                    double p, q;
                    p = B / A;
                    q = C / A;

                    double root = Math.Pow(p / 2, 2) - q;

                    if (root < 0)
                    {
                        Console.WriteLine("saknas lösning");
                    }

                    else
                    {
                        double x1, x2;
                        x1 = 0 - (p / 2) + Math.Sqrt(root);
                        x2 = 0 - (p / 2) - Math.Sqrt(root);

                        if (root == 0)
                        {
                            Console.WriteLine("en lösning");
                        }
                        else
                        {
                            Console.WriteLine("flera lösningar");
                        }
                    }
                    Console.ReadKey();
                }
                else if (Num == "15")
                {
                    int tal1, tal2;
                    Console.WriteLine("Ange ett tal");
                    tal1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ange ett tal");
                    tal2 = Convert.ToInt32(Console.ReadLine());


                    if (tal1 == tal2)
                    {
                        Console.WriteLine("talen är lika");
                        Console.WriteLine("             .#############. \r\n          .###################. \r\n       .####%####################.,::;;;;;;;;;;, \r\n      .####%###############%######:::;;;;;;;;;;;;;, \r\n      ####%%################%######:::;;;;;;;;@;;;;;;, \r\n      ####%%################%%#####:::;;;;;;;;;@;;;;;;, \r\n      ####%%################%%#####:::;;;;;;;;;@@;;;;;; \r\n      `####%################%#####:::;;;;;;;;;;@@;;;;;; \r\n        `###%##############%####:::;;;;;;;;;;;;@@;;;;;; \r\n           `#################'::%%%%%%%%%%%%;;;@;;;;;;' \r\n             `#############'.%%%%%%%%%%%%%%%%%%;;;;;' \r\n               `#########'%%%%#%%%%%%%%%%%%%%%%%%%, \r\n                 `#####'.%%%%#%%%%%%%%%%%%%%#%%%%%%, \r\n                   `##' %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                   ###  %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                    '   %%%%##%%%%%%%%%%%%%%%##%%%%% \r\n                   '    `%%%%#%%%%%%%%%%%%%%%#%%%%%' \r\n                  '       `%%%#%%%%%%%%%%%%%#%%%%' \r\n                  `         `%%%%%%%%%%%%%%%%%%' \r\n                   `          `%%%%%%%%%%%%%%' \r\n                    `           `%%%%%%%%%%'  ' \r\n                     '            `%%%%%%'   ' \r\n                    '              `%%%'    ' \r\n                   '               .%%      ` \r\n                  `                %%%       ' \r\n                   `                '       ' \r\n                    `              '      ' \r\n                    '            '      ' \r\n                   '           '       ` \r\n                  '           '        ' \r\n                              `       ' \r\n                               ' \r\n                              ' \r\n                             ' \r\n\r\n\r\na@@@@@@@@a  a@@@@@@a  a@@@@@@@a a@@@@@@@@a a@@a.  .a@@a  a@@a \r\n@@@@  @@@@ @@@@  @@@@ @@@@  @@@ @@@@@@@@@@ @@@@a  a@@@@  @@@@ \r\n@@@@  @@@@ @@@@  @@@@ @@@@  @@@    @@@@    `@@@@  @@@@'  @@@@ \r\n@@@@@@@@@@ @@@@@@@@@@ @@@@@@@@'    @@@@      `@@@@@@'    @@@@ \r\n@@@@@@@@@' @@@@@@@@@@ @@@@@@@@a    @@@@        @@@@      `@@' \r\n@@@@       @@@@  @@@@ @@@@ @@@@    @@@@        @@@@ \r\n@@@@       @@@@  @@@@ @@@@ @@@@    @@@@        @@@@       @@");
                    }
                    else
                    {
                        Console.WriteLine("talen är inte lika");
                    };
                    Console.ReadKey();
                }
                else if (Num == "16")
                {
                    Console.Write("Hej! Vad heter du?: ");
                    string username = Console.ReadLine();
                    Console.Write("Hur gammal är du?: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Hej! Välkommen min nya användare {username} och du är {age} år gammal. Nu har vi lärt känna varan. ");
                    Console.WriteLine(" *****   *****");
                    Console.WriteLine("******* *******");
                    Console.WriteLine("***************");
                    Console.WriteLine("***************");
                    Console.WriteLine("***************");
                    Console.WriteLine(" ************* ");
                    Console.WriteLine("   *********   ");
                    Console.WriteLine("     *****     ");
                    Console.WriteLine("       *       ");
                    Console.ReadKey();
                }
                else if (Num == "17")
                {
                    double x1, x2, x3, x4, y1, y2, y3, y4, xy, d;
                    Console.Write("Vad är Koordinat X i Punkt A: ");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Vad är Koordinat Y i Punkt A: ");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Vad är Koordinat X i Punkt B: ");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Vad är Koordinat Y i Punkt B: ");
                    y2 = Convert.ToInt32(Console.ReadLine());

                    x3 = x2 - x1;

                    y3 = y2 - y1;

                    x4 = Math.Pow(x3, 2);
                    y4 = Math.Pow(y3, 2);

                    xy = x4 + y4;

                    d = Math.Sqrt(xy);

                    Console.WriteLine("Avståndet mellan Punkterna är " + Math.Round(d, 2));

                    Console.ReadKey();
                }
                else if (Num == "18")
                {
                    double x = 0, y = 0;

                    Console.WriteLine("Ange x för ekvationen");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange y för ekvationen");
                    y = Convert.ToDouble(Console.ReadLine());

                    double resultat = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    Console.WriteLine("f(x) = √x^2+y^2");
                    Console.WriteLine($"svar = {Math.Round(resultat)}");
                    Console.ReadLine();
                }
                else if (Num == "19")
                {
                    Console.WriteLine("Ange x För ekvationen");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double resultat = 0;
                    resultat = Math.Pow(x, 2) + (2 * x) + 3;
                    Console.WriteLine("f(x)= x^2 + 2x +3");
                    Console.WriteLine($"funktionen restultat = {resultat}");
                    Console.ReadLine();
                }
                else if (Num == "20")
                {
                    string Secretword1 = "giraff";
                    string Secretword2 = "tiger";
                    string Secretword3 = "rockstar games";
                    string Secretword4 = "porsche";
                    string Secretword5 = "bmw";
                    string Guess1 = "";
                    string Guess2 = "";
                    string Guess3 = "";
                    string Guess4 = "";
                    string Guess5 = "";
                    int GuessLimit = 5;
                    int GuessCount = 0;
                    bool OutOfGuesses = false;

                    Console.WriteLine("All the answers are in lower case");
                    while (Guess1 != Secretword1 && !OutOfGuesses)
                    {
                        if (GuessCount < GuessLimit)
                        {
                            Console.WriteLine("What Animal has a long neck?");
                            Guess1 = Console.ReadLine();
                            GuessCount++;

                            while (Guess2 != Secretword2 && !OutOfGuesses)
                            {
                                if (GuessCount < GuessLimit)
                                {
                                    Console.WriteLine("What is the letters of this animal t_g_r");
                                    Guess2 = Console.ReadLine();
                                    GuessCount++;

                                    while (Guess3 != Secretword3 && !OutOfGuesses)
                                    {
                                        if (GuessCount < GuessLimit)
                                        {
                                            Console.WriteLine("What game studio makes the Red Dead Redemption series? ");
                                            Guess3 = Console.ReadLine();
                                            GuessCount++;

                                            while (Guess4 != Secretword4 && !OutOfGuesses)
                                            {
                                                if (GuessCount < GuessLimit)
                                                {
                                                    Console.WriteLine("What sports car company manufactures the 911? ");
                                                    Guess4 = Console.ReadLine();
                                                    GuessCount++;

                                                    while (Guess5 != Secretword5 && !OutOfGuesses)
                                                    {
                                                        if (GuessCount < GuessLimit)
                                                        {
                                                            Console.WriteLine("The Ultimate Driving Machine” is the slogan for which car company?");
                                                            Guess5 = Console.ReadLine();
                                                            GuessCount++;
                                                        }
                                                        else
                                                        {
                                                            OutOfGuesses = true;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    OutOfGuesses = true;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            OutOfGuesses = true;
                                        }
                                    }

                                }
                                else
                                {
                                    OutOfGuesses = true;
                                }
                            }

                        }
                        else
                        {
                            OutOfGuesses = true;
                        }

                    }


                    if (OutOfGuesses)
                    {
                        Console.WriteLine("You lose look below to see how many you gott correct and incorrect");
                    }
                    else
                    {
                        Console.WriteLine("You win!! all answers are correct");
                    }


                    if (Guess1 == Secretword1)
                    {
                        Console.WriteLine("Question one Correct");
                    }
                    else
                    {
                        Console.WriteLine("Question one incorrect");
                    }
                    if (Guess2 == Secretword2)
                    {
                        Console.WriteLine("Question Two Correct");
                    }
                    else
                    {
                        Console.WriteLine("Question Two incorrect");
                    }
                    if (Guess3 == Secretword3)
                    {
                        Console.WriteLine("Question Three Correct");
                    }
                    else
                    {
                        Console.WriteLine("Question Three incorrect");
                    }
                    if (Guess4 == Secretword4)
                    {
                        Console.WriteLine("Question Four Correct");
                    }
                    else
                    {
                        Console.WriteLine("Question Four incorrect");
                    }
                    if (Guess5 == Secretword5)
                    {
                        Console.WriteLine("Question Five Correct");
                    }
                    else
                    {
                        Console.WriteLine("Question Five incorrect");
                    }

                    Console.ReadKey();
                }
                Console.ReadLine();
            }
        }
    }
}