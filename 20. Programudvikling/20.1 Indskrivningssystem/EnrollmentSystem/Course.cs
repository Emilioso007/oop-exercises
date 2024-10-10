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

	public List<Student> GetParticipants ()
	{
		return participants;
	}

}