using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте словарь для хранения перевода слов с одного языка на другой.

            //Dictionary<string, string> wordTranslationRepository = new Dictionary<string, string>
            //{
            //     { "спорт", "sport" },
            //     { "словарь", "dictionary" },
            //     { "собака", "dog" }
            //};

            // Console.WriteLine("Перевод какого слова на англ язык хотите знать: спорт, словарь, собака");
            // Console.Write("введите: ");
            // string inputWord = Console.ReadLine();

            // if (string.IsNullOrEmpty(inputWord))
            // {
            //     Console.WriteLine("некорректно введено слово");
            // }
            // else
            // {
            //     inputWord = inputWord.ToLower().Trim();

            //     if (wordTranslationRepository.ContainsKey(inputWord))
            //     {
            //         Console.WriteLine($"перевод слова {inputWord} - {wordTranslationRepository[inputWord]}");
            //     }
            //     else
            //     {
            //         Console.WriteLine("веденного слова нет");
            //     }
            // }

            // Объявите словарь, содержащий информацию о продуктах в магазине


            //Dictionary<string, float> productPrices = new Dictionary<string, float>
            //{
            //    { "яблоко", 5 },
            //    { "банан", 8 },
            //    { "груша", 7 },
            //    { "молоко", 20 },
            //    { "шоколад", 50 }
            //};
            //float totalPurchasePrice = 0;

            //Console.WriteLine("продукты в магазине:");

            //foreach (string product in productPrices.Keys)
            //{
            //    Console.WriteLine(product);
            //}

            //Console.WriteLine("если завершили выбор, напишите 'выход'");

            //while (true)
            //{
            //    Console.Write("ваш выбор: ");
            //    string inputNameProduct = Console.ReadLine().ToLower().Trim();

            //    if (string.IsNullOrEmpty(inputNameProduct))
            //    {
            //        Console.WriteLine("Некорректно введено слово");
            //        continue;
            //    }

            //    if (inputNameProduct == "выход")
            //    {
            //        break;
            //    }

            //    if (!productPrices.ContainsKey(inputNameProduct))
            //    {
            //        Console.WriteLine("Такого продукта нет в магазине.");
            //        continue;
            //    }

            //    int inputProductQuantity;
            //    Console.Write("Количество: ");
            //    if (!int.TryParse(Console.ReadLine(), out inputProductQuantity) || inputProductQuantity < 0)
            //    {
            //        Console.WriteLine("Некорректно введено количество товара. Введите целое неотрицательное число.");
            //        continue;
            //    }

            //    totalPurchasePrice += productPrices[inputNameProduct] * inputProductQuantity;
            //}
            //Console.WriteLine("сумма к оплате: " + totalPurchasePrice);

            // Создайте словарь, содержащий информацию о студентах и их оценках по различным предметам.


            //Dictionary<string, Dictionary<string, int>> studentGrades = new Dictionary<string, Dictionary<string, int>>
            //{
            //    { "витя", new Dictionary<string, int>
            //        {
            //            {"русский", 5},
            //            {"математика", 5},
            //            {"английский", 5}
            //        }
            //    },
            //    { "катя", new Dictionary<string, int>
            //        {
            //            {"русский", 3},
            //            {"математика", 2},
            //            {"английский", 4}
            //        }
            //    },
            //    { "андрей", new Dictionary<string, int>
            //        {
            //            {"русский", 5},
            //            {"математика", 3},
            //            {"английский", 4}
            //        }
            //    },
            //};

            //foreach (var student in studentGrades)
            //{
            //    string studentName = student.Key;
            //    Dictionary<string, int> grades = student.Value;

            //    double averageGrade = grades.Values.Average();

            //    Console.WriteLine($"Средний балл для {studentName}: {averageGrade}");
            //}

            // Создайте словарь, содержащий информацию о книгах в библиотеке

            //Dictionary<string, int> libraryCatalog = new Dictionary<string, int>
            //{
            //    { "мастер и маргарита", 3 },
            //    { "1984", 5 },
            //    { "гордость и предубеждение", 2 },
            //    { "гарри поттер и философский камень", 7 },
            //    { "убить пересмешника", 4 }
            //};

            //while (true)
            //{
            //    Console.WriteLine("Книги доступные в библиотеке:");

            //    foreach (string key in libraryCatalog.Keys)
            //    {
            //        Console.WriteLine($"Книга {key} - доступно экземпляров {libraryCatalog[key]}");
            //    }

            //    Console.Write("Ваш выбор (название книги или 'выход'): ");
            //    string userChoice = Console.ReadLine().ToLower().Trim();

            //    if (userChoice == "выход")
            //    {
            //        break;
            //    }

            //    if (string.IsNullOrEmpty(userChoice))
            //    {
            //        Console.WriteLine("Вы ввели пустую строку. Пожалуйста, выберите книгу.");
            //        Console.Clear();
            //        continue;
            //    }

            //    if (!libraryCatalog.ContainsKey(userChoice))
            //    {
            //        Console.WriteLine("Книга с таким названием не найдена.");
            //        Console.Clear();
            //        continue;
            //    }

            //    if (libraryCatalog[userChoice] > 0)
            //    {
            //        libraryCatalog[userChoice]--;
            //        Console.WriteLine($"\nВы взяли книгу '{userChoice}'.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nЭкземпляры книги закончились!");
            //    }

            //    Console.WriteLine("\nЕще что-то хотите? (да/нет)");
            //    string userСontinues;
            //    while (true)
            //    {
            //        Console.Write("Ваш выбор: ");
            //        userСontinues = Console.ReadLine().ToLower().Trim();

            //        if (string.IsNullOrEmpty(userСontinues))
            //        {
            //            Console.WriteLine("Некорректный ввод. Введите 'да' или 'нет'.");
            //            continue;
            //        }
            //        else if (userСontinues == "да" || userСontinues == "нет")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'да' или 'нет'.");
            //        }
            //    }

            //    if (userСontinues == "нет")
            //    {
            //        break;
            //    }

            //    Console.Clear();
            //}
        }
    }
}
