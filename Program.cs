using System ;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter your name");
        string name1 = Console.ReadLine(); 
        Console.WriteLine("enter your favorite language");
        string name2 = Console.ReadLine();
        int num = DateTime.Now.Year;
        Console.WriteLine("your name is -> " + name1);
        Console.WriteLine("your favorite language is ->" + name2);
        Console.WriteLine("year is ->" + num);
    }
}