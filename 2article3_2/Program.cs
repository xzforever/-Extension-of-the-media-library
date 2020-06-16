using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo1 = new Photo("Закат", "Эта фотография была сделана в России в 1956 году", 1280, 960);
            photo1.PrintFullInfo();
            Console.WriteLine();

            List<string> actors = new List<string>();
            actors.Add("Том Хэнкс");
            Film film1 = new Film("Форрест Гамп", "Этот фильм был снят в 1994 году про персонажа,с открытым сердцем, абстроированного от человеческой жестокости и грубости", "Роберт Земекис", actors);
            film1.PrintFullInfo();
            Console.WriteLine();

            Song song1 = new Song("Иванушки Иванушки Иванушки", "Песня была записана в Москве","Иванушки", 1999, "Иванушки Иванушки");
            song1.PrintFullInfo();
            Console.WriteLine();

            Book book1 = new Book("Россия", "Книга была написана в 1871 году в лесу", "Л. Н. Толстой",1000);
            book1.PrintFullInfo();
        }
    }
}
