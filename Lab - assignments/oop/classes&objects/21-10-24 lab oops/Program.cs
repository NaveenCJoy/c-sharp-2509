using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _21_10_24_lab_oops.ShoppingCart;

namespace _21_10_24_lab_oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT 1
            //Circle class

            //try
            //{
            //    Circle circle1 = new Circle();
            //    circle1.Radius = -10;
            //    Console.WriteLine("Radius of circle is " + circle1.Radius);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();




            //ASSIGNMENT 2
            //Employee class

            //try
            //{
            //    Employee employee1 = new Employee();
            //    employee1.name = "John Doe";
            //    employee1.Salary = 15000;
            //    Console.WriteLine("Salary of " + employee1.name + " is " + employee1.Salary);
            //    Employee employee2 = new Employee();
            //    employee2.name = "Jane Smith";
            //    employee2.Salary = -1000;
            //    Console.WriteLine("Salary of " + employee2.name + " is " + employee2.Salary);
            //    Console.WriteLine("Salary of employee1 is " + employee2.Salary);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();





            //ASSIGNMENT 3
            //Library Management System

            //Library library = new Library();
            //Book book1 = new Book("book1", "author1", "12345");
            //Book book2 = new Book("book2", "author2", "98765");
            //Book book3 = new Book("book3", "author3", "10000");
            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);
            //Console.WriteLine("___________");
            //Console.WriteLine("List of Books:");
            //library.DisplayBooks();
            //Console.WriteLine("___________");
            //library.RemoveBook("98765");
            //Console.WriteLine("Book 2 removed");
            //Console.WriteLine("List of Books:");
            //library.DisplayBooks();
            //Console.ReadLine();




            //ASSIGNMENT 4
            //Banking System

            //try
            //{
            //    Bank bank = new Bank();
            //    Account account1 = new Account("123456", "John Doe");
            //    account1.AccountBalance = 5000;
            //    Account account2 = new Account("234567", "Jane Smith");
            //    account2.AccountBalance = 4500;
            //    Account account3 = new Account("345678", "Naveen Joy");
            //    account3.AccountBalance = 7000;
            //    Account account4 = new Account("456789", "test");
            //    account4.AccountBalance = 10;

            //    bank.CreateAccount(account1);
            //    bank.CreateAccount(account2);
            //    bank.CreateAccount(account3);
            //    bank.CreateAccount(account4);
            //    Console.WriteLine("_____________________");
            //    bank.DisplayAccounts();

            //    Console.WriteLine("_____________________");
            //    account1.Withdrawal(500);
            //    account2.Withdrawal(100);
            //    account3.Withdrawal(1000);
            //    account3.Deposit(1200);
            //    Console.WriteLine("_____________________");


            //    bank.DeleteAccount(account4);

            //    bank.DisplayAccounts();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadLine();





            //ASSIGNMENT 5
            //Student Management System

            //try
            //{
            //    Student student1 = new Student("John Doe", 1);
            //    Student student2 = new Student("Jane Smith", 2);

            //    student1.AddGrade(82);
            //    student1.AddGrade(91);
            //    student1.AddGrade(75);

            //    student2.AddGrade(85);
            //    student2.AddGrade(62);
            //    student2.AddGrade(93);
            //    StudentsList studentsList = new StudentsList();
            //    studentsList.AddStudent(student1);
            //    studentsList.AddStudent(student2);

            //    studentsList.DisplayStudents();
            //    Console.WriteLine(student1.CalculateGradesAverage());
            //    Console.WriteLine(student2.CalculateGradesAverage());

            //    studentsList.RemoveStudent(student1);
            //    Console.WriteLine("_______________");
            //    studentsList.DisplayStudents();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();




            //ASSIGNMENT 6
            //Inventory System
            //try
            //{
            //    Inventory inventory1 = new Inventory();

            //    Item item1 = new Item("Pen", 10, 5);
            //    Item item2 = new Item("Pencil", 12, 15);
            //    Item item3 = new Item("Eraser", 10, 5);

            //    inventory1.AddItem(item1);
            //    inventory1.AddItem(item2);
            //    inventory1.AddItem(item3);

            //    inventory1.DisplayItems();

            //    Console.WriteLine("_________________");

            //    item2.UpdateItem("Pencil", 1, 13);
            //    inventory1.DisplayItems();

            //    Console.WriteLine("_________________");

            //    inventory1.RemoveItem(item3);
            //    inventory1.DisplayItems();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();




            //ASSIGNMENT 7
            //E-commerce System
            //try
            //{
            //    Products product1 = new Products("Pencil", 100, 10);
            //    Products product2 = new Products("Pen", 30, 10);
            //    Products product3 = new Products("Eraser", 20, 8);

            //    Ecommerce ecommerce = new Ecommerce();
            //    ecommerce.AddProduct(product1);
            //    ecommerce.AddProduct(product2);
            //    ecommerce.AddProduct(product3);

            //    ecommerce.DisplayAllProducts();
            //    Console.WriteLine("________________");

            //    Orders order1 = new Orders(product1, 3);
            //    Orders order2 = new Orders(product2, 5);
            //    Console.WriteLine("________________");

            //    ecommerce.DisplayAllProducts();
            //    Console.WriteLine("________________");

            //    ecommerce.RemoveProduct(product3);
            //    ecommerce.DisplayAllProducts();
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadLine();





            //ASSIGNMENT 8
            //Print Class
            //Print printData = new Print();

            //printData.PrintInput(5);
            //printData.PrintInput("Hello");
            //printData.PrintInput(new int[] { 5, 6, 7 });

            //Console.ReadLine();





            //ASSIGNMENT 9
            //Rectangle Class
            //Rectangle rectangle1 = new Rectangle();

            //rectangle1.CalculateArea(6,5);
            //rectangle1.CalculateArea(5);

            //Console.ReadLine();





            //ASSIGNMENT 10
            //Time Class
            //Time time1 = new Time();

            //time1.SetTime(5, 40);
            //time1.SetTime(120);

            //Console.ReadLine();





            //ASSIGNMENT 11
            //Initializing a Static Field
            //StaticBank bank2 = new StaticBank(5000);
            //StaticBank bank3 = new StaticBank(6500);
            //Console.WriteLine("______________");
            //bank2.DisplayDetails();
            //bank3.DisplayDetails();

            //Console.ReadLine();





            //ASSIGNMENT 12
            //Counting Objects with Static and Instance Fields

            //CarCount car1 = new CarCount("BMW", "blue");
            //CarCount car2 = new CarCount("Audi", "white");          

            //Console.ReadLine();





            //ASSIGNMENT 13
            //Initializing Constants with Static Block

            //MathOperations op1 = new MathOperations();

            //Console.ReadLine();





            //ASSIGNMENT 14
            //Initializing Configuration with Static Constructor
            //ConfigStatic config1 = new ConfigStatic("Dark mode");
            //ConfigStatic config2 = new ConfigStatic("Light mode");
            //config1.DisplayConfirguration();
            //config2.DisplayConfirguration();

            //Console.ReadLine();





            //ASSIGNMENT 15
            //Implementing and Understanding Copy Constructor

            //EmployeeCopy employee1 = new EmployeeCopy(1, "John Doe", 25, "Chennai");
            //EmployeeCopy referenceCopy = employee1;
            //EmployeeCopy copiedEmp1 = new EmployeeCopy(employee1);

            //referenceCopy.name = "test";

            //Console.WriteLine("Original Employee:");
            //employee1.DisplayEmployee();
            //Console.WriteLine("__________________");
            //Console.WriteLine("Reference copied Employee:");
            //referenceCopy.DisplayEmployee();
            //Console.WriteLine("__________________");
            //Console.WriteLine("Actual copy of Employee:");
            //copiedEmp1.DisplayEmployee();

            //Console.ReadLine();





            //ASSIGNMENT 16
            //Identifying the Need for Chained Constructors

            //Car car1 = new Car("Tata");
            //Car car2 = new Car("Tata", "Safari");
            //Car car3 = new Car("Volkswagen", "Virtus", 2024);
            //Car car4 = new Car("Skoda", "Slavia", 2023, 2500);
            //car1.DisplayDetails();
            //car2.DisplayDetails();
            //car3.DisplayDetails();
            //car4.DisplayDetails();

            //Console.ReadLine();





            //ASSIGNMENT 17
            //Understanding the Need for Constructor Overloading

            //Product product1 = new Product("Laptop", 2500, 10);
            //Product product2 = new Product("Smartphone", 850);
            //Product product3 = new Product("AC");

            //product1.DisplayDetails();
            //Console.WriteLine("_______________");
            //product2.DisplayDetails();
            //Console.WriteLine("_______________");
            //product3.DisplayDetails();


            //Console.ReadLine();





            //ASSIGNMENT 18
            //Exploring Different Ways to Initialize Objects

            //constructor initialization
            //Product2 product1 = new Product2("Laptop", 2500, "Electronics");
            //product1.DisplayDetails();

            ////Object initializer syntax
            //Product2 product2 = new Product2 { name = "Samrtphone", price = 900, category = "Electronics" };
            //product2.DisplayDetails();

            ////static method
            //Product2 product3 = Product2.CreateProduct("AC", 1800, "Electronics");
            //product3.DisplayDetails();

            ////anonymous type
            //var anonymousProduct = new { name = "Anonymous product", price = 500, category = "Electronics" };
            //Console.WriteLine($"Name: {anonymousProduct.name}  Price: {anonymousProduct.price}  " +
            //    $"Category: {anonymousProduct.category}");


            ////reflection
            //Type productType = typeof(Product2);
            //Product2 product4 = (Product2)Activator.CreateInstance(productType, new object[]
            //{ "PC",  3000, "Electronics" });
            //product4.DisplayDetails();

            ////default values
            //Product2 product5 = new Product2();
            //product5.DisplayDetails();

            //Console.ReadLine();




            //ASSIGNMENT 20
            //Shopping Cart

            //ShoppingCart cart1 = new ShoppingCart();

            //ProductObject product1 = new ProductObject("laptop", 1500, 3);
            //ProductObject product2 = new ProductObject("Phone", 800, 5);

            //cart1.AddProduct(product1);
            //cart1.AddProduct(product2);

            //cart1.DisplayAllProducts();
            //cart1.CalculatePrice();

            //Console.ReadLine();







            //ASSIGNMENT 21
            //Banking System
            //Bank2 bank = new Bank2("Bank");

            //bank.AddCustomer("John Doe");
            //bank.AddCustomer("Jane Smith");

            //bank.AddAccount("John Doe", "12543", 5000);
            //bank.AddAccount("John Doe", "10000", 4000);
            //bank.AddAccount("John Doe", "20000", 6500);
            //bank.AddAccount("Jane Smith", "12587", 4500);

            //bank.DisplayAllCustomers();
            ////bank.DisplayCustomer("John Doe");
            ////bank.DisplayCustomer("Jane Smith");

            //Console.ReadLine();





            //ASSIGNMENT 22
            //University System
            University university1 = new University();

            university1.AddDepartment("Electrical");
            university1.AddDepartment("Physics");
            university1.AddDepartment("CS");

            university1.AddCourse("Electrical", "Electrical Machines", 210, 3);
            university1.AddCourse("Electrical", "Power systems", 211, 3);
            university1.AddCourse("Physics", "Optics", 312, 1);
            university1.AddCourse("CS", "Microcontrollers", 410, 3);

            university1.DisplayAllDetails();

            Console.ReadLine();


        }
    }
}
