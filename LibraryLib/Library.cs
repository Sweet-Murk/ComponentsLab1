using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib
{
    public class Library
    {
    }
    public class Book
    {
        public string Name { get; set; }
        public string Authur { get; set; }
        public int YearCreation { get; set; }
        public int Publications { get; set; }
        public int Pages { get; set; }

        public Book() { Name = "Неизвестно"; Authur = "Неизвестно"; YearCreation = 0; Publications = 0; Pages = 0; }

        public Book(string name) { Name = name; Authur = "Неизвестно"; YearCreation = 0; Publications = 0; Pages = 0; }

        public Book(string name, string authur) { Name = name; Authur = authur; YearCreation = 0; Publications = 0; Pages = 0; }

        public Book(string name, string authur, int yearCreation) { Name = name; Authur = authur; YearCreation = yearCreation; Publications = 0; Pages = 0; }

        public Book(string name, string authur, int yearCreation, int publications) { Name = name; Authur = authur; YearCreation = yearCreation; Publications = publications; Pages = 0; }

        public Book(string name, string authur, int yearCreation, int publications, int pages) { Name = name; Authur = authur; YearCreation = yearCreation; Publications = publications; Pages = pages; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Название: {Name}  Автор: {Authur}  Год издания: {YearCreation}  Тираж: {Publications}  Страниц: {Pages}");
        }
        public void InfReflection()
        {
            Console.WriteLine("You are there");
        }
    }
    public interface IBook
    {
        void WriteAboutBook();
    }
    public interface IClient
    {
        void WriteAboutClient();
    }


    public class Lib : Book, IBook, IClient
    {
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BookSearch="";

        public Lib() {
            Name = "Неизвестно";
            Number = 0;
            LastName = "Не записан";
            FirstName = "";
        }

        public Lib(string name)
    : base(name)
        {
            Number = 0;
            LastName = "Не записан";
            FirstName = "";
        }

        public Lib(string name, int number, string lastName, string firstName)
            : base(name)
        {
            Number = number;
            LastName = lastName;
            FirstName = firstName;
        }
        void IBook.WriteAboutBook() => Console.WriteLine($"Книга: {Name}  Номер: {Number}");
        void IClient.WriteAboutClient() => Console.WriteLine($"Взял: {LastName} {FirstName}");
        public override void GetInfo()
        {
            Lib obj = new Lib(Name, Number, LastName, FirstName);
            IBook link1 = (IBook)obj;
            link1.WriteAboutBook();
            IClient link2 = (IClient)obj;
            link2.WriteAboutClient();
        }
        public string PopularSearch(string ganre)
        {
            if(ganre=="fantasy")
            {
                BookSearch = "Гарри Поттер";
            }
            else if(ganre=="drama")
            {
                BookSearch = "Последнее желание";
            }
            else if(ganre== "detective")
            {
                BookSearch = "Зелёная миля";
            }
            else if (ganre=="scienсe")
            {
                BookSearch = "Эгоистичный ген";
            }
            return BookSearch;
        }
    }
}
