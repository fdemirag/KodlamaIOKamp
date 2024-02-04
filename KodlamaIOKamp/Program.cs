// See https://aka.ms/new-console-template for more information
using KodlamaIOKamp.Business;
using KodlamaIOKamp.Entities;

Console.WriteLine("Hello, World!");


string message = "Krediler";
int term = 12;
double amount = 100000.5;

//variables --> camelCase
bool isAuthenticated = true;

//condition
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Fatih");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");
}

//Array
string[] loans = { "kredi1","kredi2","kredi3"}; //dbden gelecek
//string[] loans2 = new string[6];
//loans2[0] = "kredi1";
//string kredi2 = "kredi2";

    //start       condition     increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Name = "c#";
course1.Id = 1;
course1.Description = ".NET 8";
course1.Price = 0;


Course course2 = new Course();
course2.Name = "Java";
course2.Id = 2;
course2.Description = "JAVA 8";
course2.Price = 10;

Course course3 = new Course();
course3.Name = "Python";
course3.Id = 3;
course3.Description = "Python 3.12";
course3.Price = 00;

Course[] courses = { course1, course2, course3 };

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();


for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses2[i].Name+ " / "+ courses2[i].Price);
}


Console.WriteLine( "Kod Bitti");