using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_SWII6
{
    internal class Book
    {
        public string Name { get; }
        public Author[] Authors { get; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book() { }

        public Book(string name, Author[] authors, double price)
        {
            Name = name;
            Authors = authors;
            Price = price;
        }

        public Book(string name, Author[] authors, double price, int qty)
        {
            Name = name;
            Authors = authors;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {
            string authors = "";
            foreach (Author author in Authors)
            {
                authors += $"Author[name={author.Name}, email={author.Email}, gender={author.Gender}], ";
                if (author.Equals(Authors.Last()))
                {
                    authors = authors.Substring(0, authors.Length - 2);
                }
            }

            return $"Book[name={Name}, authors=[{authors}], price={Price}, qty={Qty}";
        }

        public string getAuthorNames()
        {
            string names = "";
            foreach (Author author in Authors)
            {
                names += $"{author.Name}, ";
                if (author.Equals(Authors.Last()))
                {
                    names = names.Substring(0, names.Length - 2);
                }
            }
            return names;
        }
    }
}
