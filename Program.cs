using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        #region 1

        //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        #endregion

        #region 2
        //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
        string firstLine = "Clean Code";
        string secondLine = "Clean Code";
        Console.WriteLine(ReferenceEquals(firstLine, secondLine));

        #endregion

        #region 3
        //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result
        StringBuilder s1 = new StringBuilder();
        s1.Append("Book List");
        s1.Append("Updated");
        Console.WriteLine(s1);
        #endregion

        #region 4
        //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
        s1.Replace("Book List", "Library");
        Console.WriteLine(s1);

        #endregion

        #region 5
        //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator
        string title2 = "Clean Code";
        int pages = 464;
        Console.WriteLine("Book: " + title + ", Pages: " + pages);

        #endregion

        #region 6
        //Build the same sentence as above, but using string interpolation ($"...").
        Console.WriteLine($"Book: {title2}, Pages: {pages}");
        #endregion

        #region 7
        //Build the same sentence again, but using string.Format().
        Console.WriteLine(string.Format("Book:{0}, Pages:{1}", title2, pages));

        #endregion

        #region 8
        //Declare a nullable integer int? pages = null;. Use the Null Coalescing Operator (??) to print pages or 0 if it is null.
        int? pages2 = null;
        Console.WriteLine(pages2 ?? 0);

        #endregion

        #region 10
        //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(prices[1]);
        #endregion
    }
}
