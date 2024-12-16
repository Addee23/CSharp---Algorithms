namespace Uppgift_Algoritmer
{
    public class Program
    {
        List<Student> students = new List<Student>();

        static void Main(string[] args)
        {

            //Lägger till studenter
            AddStudent("Adina", 95);
            AddStudent("Anna", 68);
            AddStudents("Lars", 87);
            AddStudents("John", 78);


            Console.WriteLine("\nStudenter innan sortering: ");
            PrintStudents();

            //Sorterar studenter
            BubbleSortStudents();

            //Efter sortering

            Console.WriteLine("\nStudenter efter sortering: ");
            PrintStudents();
        }
        //Metoder
    }
}
