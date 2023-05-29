class Program
    {
        static void Main(string[] args)
        {
            bool ordning;
            int antalLoopar;
            int antalElever;
            List<string> klassLista = new List<string>();
            Random random = new Random();


           
            Console.Write("Hur många elever vill du lägga till i klasslistan?: ");
            while(true)
            {    
                try
                {
                    antalElever = int.Parse(Console.ReadLine());
                    if(antalElever > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Du måste ange ett tal som är större än 0, skriv igen: ");
                    }
                }
                catch
                {
                    Console.Write("Du får bara ange tal! Skriv hur många elever du vill lägga till: ");
                }
            }
           
            Console.Write("Välj ordningen som du vill lägga till namnet, skriv 1 om du vill lägga till förnamn först och sen efternamn, annars läggs efternamn först: ");
            string ordningPåNamn = Console.ReadLine();
            if(ordningPåNamn == "1")
            {
                ordning = true;
            }
            else
            {
                ordning = false;
            }
            antalLoopar = antalElever;
           
            while(antalLoopar > 0)
            {
                klassLista.Add(SkrivaNamn(ordning));
                antalLoopar--;
            }


           
            int slumpatTal = random.Next(0,antalElever);
            Console.WriteLine(klassLista[slumpatTal]);
            slumpatTal = random.Next(0,antalElever-1);
            Console.WriteLine(klassLista[slumpatTal]);
            Console.ReadLine();
        }


        static string SkrivaNamn(bool ordning)
        {
            string efternamn;
            string förnamn;
            string helaNamnet;
     
            Console.Write("Skriv in ditt namn: ");
            while(true)
            {
                förnamn = Console.ReadLine();
                if(förnamn.Length == 0 || förnamn.Length > 64)
                {
                    Console.Write("Du får bara skriva in förnamn på 1-64 bokstäver, skriv igen: ");
                }
                else
                {
                    break;
                }
            }
           
            Console.Write("Skriv in ditt efternamn: ");
            while(true)
            {
                efternamn = Console.ReadLine();
                if(efternamn.Length == 0 || efternamn.Length > 64)
                {
                    Console.Write("Du får bara skriva in efternamn på 1-64 bokstäver, skriv igen: ");
                }
                else
                {
                    break;
                }
            }
            if(ordning)
            {
                helaNamnet = förnamn + " " + efternamn;
            }
            else
            {
                helaNamnet = efternamn + " " + förnamn;
            }


            return helaNamnet;
        }
    }


