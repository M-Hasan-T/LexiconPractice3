using static System.Net.Mime.MediaTypeNames;

namespace LexiconPractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteQuestion("5. När denna klass är klar, kommentera bort er tidigare instans av Person från Program.cs, och instansiera istället en PersonHandler. Skapa därigenom några personer och testa era metoder.");

            try
            {
                //Person person = new Person() { FName = "Beth", LName = "Perth" };
                PersonHandler personHandler = new PersonHandler();
                Person beth = personHandler.CreatePerson(20, "Beth", "Perth", 165, 54.5);
                Console.WriteLine();
                Console.WriteLine(beth.Age);
                Console.WriteLine(beth.FName);
                Console.WriteLine(beth.LName);
                Console.WriteLine(beth.Height);
                Console.WriteLine(beth.Weight);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }

            WriteQuestion("8.Skriv ut samtliga UserErrors UEMessage() genom en foreach loop.");

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());

            Console.WriteLine();
            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            WriteQuestion("9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage() 10. Testa och se så det fungerar.");

            userErrors.Add(new CustomError("This is the first custom error!"));
            userErrors.Add(new CustomError2("This is the second custom error!"));
            userErrors.Add(new CustomError3("This is the third custom error!"));

            Console.WriteLine();
            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            WriteQuestion("5.Skriv ut vilka djur som finns i listan med hjälp av en foreach-loop");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Bird("Birdy", 0.5, 2));
            animals.Add(new Dog("Dogy", 50, 5));
            animals.Add(new Flamingo("Flamy", 3.2, 20));
            animals.Add(new Hedgehog("Hedgy", 0.8, 12));
            animals.Add(new Horse("Lucky Luke", 1000, 15));
            animals.Add(new Pelican("Pely", 7.5, 17));
            animals.Add(new Swan("Swany", 15, 19));
            animals.Add(new Wolf("Wolfy", 76, 7));
            animals.Add(new Wolfman("Kurt", 200, 19));
            animals.Add(new Worm("Mustard", 0.25, 3));

            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stat());
                animal.DoSound();
                if (animal is IPerson person)
                    Console.WriteLine(person.Talk());
                Console.WriteLine(new String('=', 30));
            }

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("FirstDog", 10, 1));
            dogs.Add(new Dog("SecondDog", 20, 2));
            dogs.Add(new Dog("ThirdDog", 30, 3));
            //dogs.Add(new Horse("FirstHorse", 500, 5));

            List<Animal> animals2 = new List<Animal>();
            animals2.Add(new Dog("FirstDog", 45, 3));
            animals2.Add(new Horse("SecondHorse", 450, 10));
            animals2.Add(new Wolf("FirstWolf", 50, 4));
            animals2.Add(new Dog("SecondDog", 35, 1));

            WriteQuestion("11. Skriv ut samtliga Animals Stats() genom en foreach loop.");

            foreach (Animal animal in animals2)
            {
                Console.WriteLine();
                Console.WriteLine(animal.Stat());
                Console.WriteLine();
                Console.WriteLine(new String('=', 30));
            }

            WriteQuestion("14. Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.");

            foreach (Animal animal in animals2)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine();
                    Console.WriteLine(animal.Stat());
                    Console.WriteLine();
                    Console.WriteLine(new String('=', 30));
                }
            }

            WriteQuestion("18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.");

            foreach (var animal in animals2)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine();
                    Console.WriteLine(dog.RandomMethod());
                    Console.WriteLine();
                    Console.WriteLine(new String('=', 30));
                }
            }

            void WriteQuestion(string str)
            {
                Console.WriteLine($"\n{new String('=', 30)}\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str);
                Console.ResetColor();

            }
        }

        //--13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
        //--13. S: Bird klass

        //--14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        //--14. S: Animal klass

        //--9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
        //--9. S: En lista representerar en starkt typad lista med objekt. Vi kan inte använda två olika klasser i en lista även om de ärvs från samma klass.
        //--9. S: Ett av de undantagsfall där man lägger till två eller flera klasser i en lista är i svaret på följande fråga.

        //--10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
        //--10. S: Som framgår av exemplet nedan måste dess typ vara Animal. På så sätt kan vi lägga till alla djurklasser som ärver från Animal class.
        /*  List<Animal> animals2 = new List<Animal>();
            animals2.Add(new Dog("FirstDog", 45, 3));
            animals2.Add(new Horse("SecondHorse", 450, 10));*/

        //--17. F: Kommer du åt den metoden från Animals listan? Varför inte?
        //--17. S: Klassen 'Animal' innehåller ingen definition för 'RandomMethod' och ingen tillgänglig förlängningsmetod 'RandomMethod'.
    }
}