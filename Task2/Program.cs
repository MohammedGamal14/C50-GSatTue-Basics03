namespace Task2
{
    internal class Program
    {
        static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        static void Main(string[] args)
        {
            #region Q1
            // Declare string title = "clean code";. Call title.ToUpper() and store it in upperTitle.
            // Print both to show that title did not change.
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Q2
            // Declare two string variables with the literal "Clean Code".
            // Use ReferenceEquals() to check if they point to the same object.
            string firstBookTitle = "Clean Code";
            string secondBookTitle = "Clean Code";
            Console.WriteLine(ReferenceEquals(firstBookTitle, secondBookTitle));
            #endregion

        }
    }
}
