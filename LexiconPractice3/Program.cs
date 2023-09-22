namespace LexiconPractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Person person = new Person() { FName = "Beth", LName = "Perth" };
                PersonHandler personHandler = new PersonHandler();
                Person beth = personHandler.CreatePerson(-20, "B", "Pe", 165, 54.5);
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

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());

            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            userErrors.Add(new CustomInputError("asdf"));

        }
    }
}