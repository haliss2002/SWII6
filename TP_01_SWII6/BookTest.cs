using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_SWII6
{
    public class BookTest
    {

        public BookTest()
        {
            Console.WriteLine("---- Test ----");
            var author1 = new Author("Stephen King I", "stephenI@emmail.com", 'M');
            var author2 = new Author("Stephen King II", "stephenII@emmail.com", 'M');
            Author[] authorsBook1 = { author1, author2 };
            var book1 = new Book("O Iluminado", authorsBook1, 50.00, 5);

            Console.WriteLine($"Nomes dos autores: {book1.getAuthorNames()}");
            Console.WriteLine($"Dados do livro: {book1.ToString()}");
        }
    }
}
