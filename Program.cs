namespace canvascsharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
            int alder = 30;
            Console.WriteLine(alder);

            //Lag en variabel av datatypen string og tildel en vilkårlig tekst
            string navn = "Yoel";
            Console.WriteLine(navn);

            //Lag en variabel av datatypen double og tildel et vilkårlig tall
            double høyde = 1.81;
            Console.WriteLine(høyde);

            //Lag en variabel av datatypen char og tildel den en vilkårlig karakter
            char kjønn = 'M';
            Console.WriteLine(kjønn);

            //Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
            int[] numbers = { 1, 12, 23, 34, 45 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
            string[] names = { "Yoel", "Jonas", "Roar", "Martin", "Anne"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Lag en List av datatypen string og skriv ut verdiene
            List<string> myExampleList = new List<string>();

            myExampleList.Add("Hei");
            myExampleList.Add("dette");
            myExampleList.Add("er");
            myExampleList.Add("en");
            myExampleList.Add("liste");
            foreach (string word in myExampleList)
            {
                Console.WriteLine(word);
            }

            //Lag en Dictionary med integer-nøkkel og string-verdi
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "Koding");
            myDictionary.Add(2, "er");
            myDictionary.Add(3, "gøy");
            myDictionary.Add(4, "og");
            myDictionary.Add(5, "vanskelig");

            foreach (var item in myDictionary) 
            {
            Console.WriteLine($"Nøkkel: {item.Key}, Verdi: {item.Value}");
            }

            //Lag en metode av typen integer som legger sammen to tall, int a og int b
            int sum = Add(24, 36);
            
            Console.WriteLine(sum);

            //Lag en metode av typen string som skrive ut en liten hilsen ved å bruke en parametervariabel
            Console.Write("Skriv inn brukernavnet ditt: ");
            string? userName = Console.ReadLine();

            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Du må skrive inn et brukernavn.");
                return;
            }

            string greeting = WriteGreeting(userName);
            Console.WriteLine(greeting);



        }
       
        
        static string WriteGreeting(string userName)
        {
            return $"Hei og velkommen, {userName}";
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}