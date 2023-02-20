using OOproduct;
using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace OOproduct
{

    public class Product
    {
        protected string name;
        protected string description;
        protected double price;
        protected double postage;
        protected int amount;

        /*public double calcTotal()
        {
            double orderTotal;
           orderTotal = postage + (price * amount);
            return orderTotal;
        }*/

        public Product(string nme, string desc, double pri, double pos, int amon)
        {
            Console.WriteLine("Creating an object of the class product");
            name = nme;
            description = desc;
            price = pri;
            postage = pos;
            amount = amon;
            Console.WriteLine("object created");
        }
        public double calcTotal()
        {
            double proTotal;
            proTotal = (price * amount) + postage;
            return proTotal;
        }
        public void displayProduct()
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine(price);
            Console.WriteLine(postage);
            Console.WriteLine(amount);
        }
        public void set_postage(double Post)
        {
            if (Post < 0) 
            { postage= 10.00; }
            else
                postage= Post;
        }

        public double get_postage() 
        { 
            return postage;
        }
    }
}
public class Book : Product
{
    private string author;
    private string title;

    public Book(string nme, string desc, double pri, double pos, int amon, string auth, string tit) : base(nme, desc, pri, pos, amon)
    {
        author = auth;
        title = tit;
    } public void displayProduct()
    {
        Console.WriteLine(name);
        Console.WriteLine(description);
        Console.WriteLine(price);
        Console.WriteLine(postage);
        Console.WriteLine(amount);
        Console.WriteLine(author); 
        Console.WriteLine(title);
    }
}
    class program
    {
        public static void Main(string[] args)
        {
        /* double calcTotal;
         Console.WriteLine("Creating Product");
         Product pro1 = new Product();
         Console.WriteLine("Name?");
         pro1.name = Console.ReadLine();
         Console.WriteLine("description?");
         pro1.description = Console.ReadLine();
         Console.WriteLine("price?");
         pro1.price = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("postage");
         pro1.postage = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("amount?");
         pro1.amount = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine(pro1.name + " " + pro1.description + " costs " + pro1.price);

         Console.WriteLine("Your order total is " + pro1.calcTotal()); 
            string Name;
            string Desc;
            double Price;
            double Postage;
            int amount;

         Console.WriteLine("Product?");
         Name= Console.ReadLine();
         Console.WriteLine("Description?");
         Desc= Console.ReadLine();
         Console.WriteLine("Price?");
         Price= Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Postage?");
         Postage = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Amount?");
         amount = Convert.ToInt32(Console.ReadLine ());

        Product pro1 = new Product(Name, Desc, Price, Postage, amount);
         Console.WriteLine("Product info:");
         pro1.displayProduct();

         Console.WriteLine("Order Total: "+ pro1.calcTotal());*/

        List<Book> listOfBooks = new List<Book>();
        Book book1 = new Book("A book", "You Read it", 10, 3,2,"Stephen King", "Pet Sematary");
        listOfBooks.Add(book1);
        Book book2 = new Book("Book", "A spooky tale", 12, 3, 1, "H.P. Lovecraft", "Dagon");
        listOfBooks.Add(book2);
        Book book3 = new Book("Book", "A spooky Japanese tale", 15, 10, 1, "Jujni Ito", "Hellstar Remina");
        listOfBooks.Add(book3);

        double Total = 0;

        foreach(Book book in listOfBooks)
        {
            Console.WriteLine("**********************");
            book.displayProduct();
            Total= book.calcTotal() + Total;
            Console.WriteLine("Order Total: " + book.calcTotal());
        }
        Console.WriteLine(Total);
        }
    }
