using System.Text;

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

            #region Q3
            // Create a StringBuilder, Append "Book List", then Append " - Updated". Print the result.
            StringBuilder titleBuilder = new StringBuilder();
            titleBuilder.Append("Book List");
            titleBuilder.Append(" - Updated");
            Console.WriteLine(titleBuilder);
            #endregion

            #region Q4
            // Use Replace() to change "Book List" into "Library". Print the result.
            titleBuilder.Replace("Book List", "Library");
            Console.WriteLine(titleBuilder);
            #endregion

            #region Q5
            // Build "Book: Clean Code, Pages: 464" using the + operator.
            string bookTitle = "Clean Code";
            int pages = 464;
            string plusSentence = "Book: " + bookTitle + ", Pages: " + pages;
            Console.WriteLine(plusSentence);
            #endregion

            #region Q6
            // Build the same sentence using string interpolation.
            string interpolatedSentence = $"Book: {bookTitle}, Pages: {pages}";
            Console.WriteLine(interpolatedSentence);
            #endregion


        }
    }
}
