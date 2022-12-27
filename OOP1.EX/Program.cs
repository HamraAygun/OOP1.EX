using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Students students = new Students();

        students.Name = "Hamra";
        students.Surname = "Aygün";
        students.Age = 27;
        students.No = 1;
        students.Gender = "Famale";

        Console.WriteLine("Öğrencinin Adı: " + students.Name + " - " + "Öğrencinin Soyadı: " + students.Surname + " - " + "Öğrencinin Yaşı: " + students.Age + " - "+ "Öğrencinin Numarası: " + " - " + "Öğrencinin Cinsiyeti: " + students.Gender);

        Console.ReadKey();
    }
    
    public class Students
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int No { get; set; }
        public string Gender { get; set; }
    }


    
   
}