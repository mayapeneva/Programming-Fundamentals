namespace E_BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class LibraryModification
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var listOfAuthors = new Dictionary<string, DateTime>();
            for (int i = 0; i < n; i++)
            {
                var listOfBooks = Console.ReadLine().Split(' ');
                var library = new Library { Title = listOfBooks[0],
                    Books = new Book { ReleaseDate = DateTime.ParseExact(listOfBooks[3], "dd.MM.yyyy", CultureInfo.InvariantCulture) } };

                if (!listOfAuthors.ContainsKey(library.Title))
                {
                    listOfAuthors[library.Title] = new DateTime();
                }

                listOfAuthors[library.Title] = library.Books.ReleaseDate;
            }

            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var result = listOfAuthors.OrderBy(x => x.Value).ThenBy(y => y.Key);
            foreach (var author in result)
            {
                if (author.Value > givenDate)
                {
                    Console.WriteLine($"{author.Key} -> {author.Value.ToString("dd.MM.yyyy")}");
                }
            }
        }
    }
}
