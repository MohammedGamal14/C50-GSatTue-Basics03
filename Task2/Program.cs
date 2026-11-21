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

        }
    }
}
