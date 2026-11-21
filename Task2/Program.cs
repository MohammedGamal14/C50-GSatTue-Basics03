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

            #region Q7
            // Build the same sentence using string.Format().
            string formattedSentence = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);
            Console.WriteLine(formattedSentence);
            #endregion

            #region Q8
            // Print "Long Book" if pages > 300, otherwise "Short Book".
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Q9
            // Print "You can borrow this book" only if pages > 300 and isAvailable is true (&&).
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region Q10
            // Switch on title: "Clean Code" -> "Great choice!", "Refactoring" -> "Nice pick!",
            // anything else -> "Never heard of it".
            string selectedTitle = "Refactoring";
            switch (selectedTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q11
            // Use the ternary operator to store "Long Book" or "Short Book" in sizeLabel.
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region Q12
            // Use a for loop to print each book with its position number, like 1. Clean Code.
            for (int bookIndex = 0; bookIndex < books.Length; bookIndex++)
            {
                Console.WriteLine((bookIndex + 1) + ". " + books[bookIndex]);
            }
            #endregion

            #region Q13
            // Use a while loop to print every book title.
            int whileIndex = 0;
            while (whileIndex < books.Length)
            {
                Console.WriteLine(books[whileIndex]);
                whileIndex++;
            }
            #endregion


            #region Q14
            // Write a do-while loop that prints "Checking book..." exactly 3 times.
            int checkCount = 0;
            do
            {
                Console.WriteLine("Checking book...");
                checkCount++;
            } while (checkCount < 3);
            #endregion





        }
    }
}
