using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace три
{
    internal class Reader
    {
        public string FIO;
        public string NomerChB;
        public string Fakultet;
        public string DataR;
        public string NomerT;

        public Reader() { }
        public Reader(string FIO, string NCB, string F, string DR, string NT) { this.FIO = FIO; NomerChB = NCB; Fakultet = F; DataR = DR; NomerT = NT; }

        //string[] books = new string[5] { "Martin eden by Jack London", "Eugene Onegin by Pushkin", "The small prince by Antoine de Saint-Exupéry" };

        public void takeBook(int KolvoVzKnig)
        {
            Console.WriteLine($"{FIO} взял {KolvoVzKnig} книг.\n");
        }
        public void takeBook(string t1, string t2, string t3, string t4, string t5)
        {
            Console.WriteLine($"{FIO} взял такие книги как {t1},{t2},{t3},{t4},{t5}.\n");
        }
        public void takeBook(Book b) //?????????????????????????????????????
        {
            Console.WriteLine($"{FIO} взял такие книги как {Book.Nazvaniye} от {Book.Avtor} .\n");
        }
        public void returnBook(int KolvoVzKnig)
        {
            Console.WriteLine($"{FIO} вернул {KolvoVzKnig} книг.\n");
        }
        public void returnBook(string t1, string t2, string t3, string t4, string t5)
        {
            Console.WriteLine($"{FIO} вернул такие книги как {t1},{t2},{t3},{t4},{t5}.\n");
        }
    }
}
