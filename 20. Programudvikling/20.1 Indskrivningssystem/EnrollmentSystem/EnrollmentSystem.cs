namespace EnrollmentSystem;

public class EnrollmentSystem
{

	public List<Student> students;
	public List<Course> courses;

	public EnrollmentSystem()
	{
		students = new List<Student>();
		courses = new List<Course>();
	}

	public void AddStudent(Student student)
	{
		students.Add(student);
	}

	public void RemoveStudent(int idToRemove)
	{
		for (int i = students.Count; i >= 0; i--)
		{
			if (students[i].id == idToRemove)
			{
				students.RemoveAt(i);
			}
		}
	}

	public void AddCourse(Course course)
	{
		courses.Add(course);
	}

	public void RemoveCourse(int idToRemove)
	{
		for (int i = courses.Count; i >= 0; i--)
		{
			if (courses[i].id == idToRemove)
			{
				courses.RemoveAt(i);
			}
		}
	}

	public void Enroll(Student student, Course course)
	{
		course.Enroll(student);
	}

	public void Remove(Student student, Course course)
	{
		course.Remove(student);
	}

	public void ShowParticipants(Course course)
	{
		foreach (Student student in course.GetParticipants())
		{
			Console.WriteLine(student.GetName());
		}
	}

	public List<Course> GetCourses()
	{
		return courses;
	}

	public List<Student> GetStudents()
	{
		return students;
	}

}