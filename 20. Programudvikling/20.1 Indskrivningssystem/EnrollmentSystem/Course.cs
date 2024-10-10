namespace EnrollmentSystem;

public class Course
{

	public string name;
	public List<Student> participants;
	public int id;

	public Course (string nameValue, int idValue)
	{
		name = nameValue;
		id = idValue;
		participants = new List<Student>();
	}

	public void Enroll (Student student)
	{
		participants.Add(student);
	}

	public void Remove (Student student)
	{
		participants.RemoveAll(student);
	}

	public Student[] GetParticipants ()
	{
		// count number of entries
		int count = 0;
		foreach (Student student in participants)
		{
			if (student != null)
			{
				count++;
			}
		}

		// make a copy
		Student[] result = new Student[count];
		int index = 0;
		foreach (Student student in participants)
		{
			if (student != null)
			{
				result[index++] = student;
			}
		}
		return result;
	}

}