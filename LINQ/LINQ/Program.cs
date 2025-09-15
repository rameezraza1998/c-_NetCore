 class Program
{
    List<string> students = new List<string>();

    public void AddStudent(string Stdname)
    {
        string name = Stdname;
        students.Add(name);
    }

    public void DisplayStudent()
    {

        foreach (var student in students)
        { 
        Console.WriteLine(student);
        }
    
    }

    public void GetStudentWithFirstletter(char letter)
    {
        //var result = from student in students
        //             where student.StartsWith(letter)
        //             select student;

        var FilteredResult = students.Where(s => s.StartsWith(letter));

        foreach (var student in FilteredResult)
        { 
            Console.WriteLine(student);
        }
    }


    private static void Main(string[] args)
    {


        Program program = new Program();
         
        //int[] data  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //var greaterThanThree = data.Where(n => n > 3).OrderByDescending(n => n);
        //Console.WriteLine(greaterThanThree);


        //foreach (var number in greaterThanThree)
        //{
        //    Console.WriteLine(number);
        //}

        //program.AddStudent("Ramis");
        //program.AddStudent("Qasim");
        //program.AddStudent("Raza");
        //program.AddStudent("Ali");
        //Console.WriteLine("Student List:");
        //program.DisplayStudent();

        //Console.WriteLine("Students with first letter R:");
        //program.GetStudentWithFirstletter('R');






        //Console.WriteLine("Hello LINQ !! ");
    }
}