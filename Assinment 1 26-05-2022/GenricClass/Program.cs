 
public class Program
{
	public static void Main()
	{
		var students = new List<Student>() {
				new Student(){ Id = 1, Name="Bill" },
				new Student(){ Id = 2, Name="Steve" },
				new Student(){ Id = 3, Name="Ram" },
				new Student(){ Id = 4, Name="Abdul" },
				new Student(){ Id = 5, Name="Bill" }
		};


		foreach (var student in students)
			Console.WriteLine(student.Id + ", " + student.Name);
	}
}

public class Student
{
	public int Id { get; set; }
	public string Name { get; set; }

}