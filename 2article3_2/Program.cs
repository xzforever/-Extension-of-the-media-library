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
            Photo photo1 = new Photo();
            photo1.Title = "Закат";
            photo1.Description = "Эта фотография была сделана в России в 1956 году";
            photo1.Height = 1280;
            photo1.Width = 960;
            photo1.PrintFullInfo();
            Console.WriteLine();

            Film film1 = new Film();
            film1.Title = "Форрест Гамп";
            film1.Description = "Этот фильм был снят в 1994 году про персонажа,с открытым сердцем, абстроированного от человеческой жестокости и грубости";
            film1.Director = "Роберт Земекис";
            film1.Actors.Add("Том Хэнкс");
            film1.PrintFullInfo();
            Console.WriteLine();

            Song song1 = new Song();
            song1.Title = "Иванушки Иванушки Иванушки";
            song1.Description = "Песня была записана в Москве";
            song1.Band = "Иванушки";
            song1.Year = 1999;
            song1.Album = "Иванушки Иванушки";
            song1.PrintFullInfo();
            Console.WriteLine();

            Book book1 = new Book();
            book1.Title = "Россия";
            book1.Description = "Книга была написана в 1871 году в лесу";
            book1.Autor = "Л. Н. Толстой";
            book1.PageNum = 1000;
            book1.PrintFullInfo();
        }
    }
}
