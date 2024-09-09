/*
 Koden är skriven av: 
                        Parman Gitijah (Parre)
 i klass:
                        Fullstackutveckling .net 2024
 */
namespace MyFirstProgram__Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Användaren skriver ett tal.
            Console.WriteLine("Skriv in ett tal: ");
            // Skapar variabeln number som är av formen int och converterar till int.
            int number = Convert.ToInt32(Console.ReadLine());

            // Skapar if satsen och else satsen.
            if (number < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            else
            {
                Console.WriteLine("Talet är stort!");
            }
            // Direkt efter if satsen frågar programmet om användarens namn. 
            Console.WriteLine("Vad heter du? ");
            // Skapar variabeln name av formen string. 
            string name = Console.ReadLine();
            // Skriver hej till användaren
            Console.WriteLine("Hej " + name + "!");

            // Innan programmet skriver alla tal fram till number informerar jag användaren om det. 
            // För att fortsätta behöver användaren trycka på någon tangent.
            Console.WriteLine("Nu skriver programmet upp alla tal upp till " + number);
            Console.WriteLine("Tryck 'Enter' för att fortsätta");
            Console.ReadLine();

            // ger variabeln tal värdet 0
            int tal = 0;

            /*
            skapar en for loop.
            Parantesen innehåller 3 vilkorssatser
            1. definera i;
            2. definera hur länge i ska loopas
            3. i++, varje gång loopen går så plussas i med 1!
            */
            for (int i = tal; i <= number; i++)
            {
                Console.WriteLine(i);
            }


            // Programmet väntar så att användaren kan läsa in!
            Console.ReadLine();

        }




    }
}
