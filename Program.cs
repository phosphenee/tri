using System.Runtime.InteropServices;

namespace три
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ex.1

            Reader KichakIA = new Reader("Кичак Иван Антонович","1","Факультет информационных технологий","07.02.2007","8-913-950-23-70");

            Reader KamnevAA = new Reader("Камнев Алексей Александрович","2","Факультет информационных технологий","03.05.2006","8-983-228-13-37");

            string[,] Readers = new string[2, 5] { {KichakIA.FIO , KichakIA.NomerChB , KichakIA.Fakultet , KichakIA.DataR , KichakIA.NomerT },
                {KamnevAA.FIO , KamnevAA.NomerChB , KamnevAA.Fakultet , KamnevAA.DataR , KamnevAA.NomerT } };



            int rows = Readers.GetUpperBound(0) + 1;    // количество строк
            int columns = Readers.Length / rows;        // количество столбцов
                                                        // или так
                                                        // int columns = numbers.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Readers[i, j]} \n");
                }
                Console.WriteLine();
            }



            Book EugeneOnegin = new Book { };
            KichakIA.takeBook(5);
            KichakIA.takeBook("Азбука" , "Энциклопедия" , "Словарь" , "Сборник сказок" , "Учебник");
            KichakIA.takeBook(EugeneOnegin); //?????????????????????????????????????
            KichakIA.returnBook(5);
            KichakIA.returnBook("Азбука", "Энциклопедия", "Словарь", "Сборник сказок", "Учебник");

            // ex.2

        }
    }
}