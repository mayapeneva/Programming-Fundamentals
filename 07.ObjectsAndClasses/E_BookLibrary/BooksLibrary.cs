namespace E_BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BooksLibrary
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var listOfAuthors = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var listOfBooks = Console.ReadLine().Split(' ');
                var library = new Library { Name = listOfBooks[1], Books = new Book{ Price = double.Parse(listOfBooks[5])} };

                if (!listOfAuthors.ContainsKey(library.Name))
                {
                    listOfAuthors[library.Name] = 0;
                }

                listOfAuthors[library.Name] += library.Books.Price;
            }

            var result = listOfAuthors.OrderByDescending(x=> x.Value).ThenBy(y => y.Key);
            foreach (var author in result)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
}
