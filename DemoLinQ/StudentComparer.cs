namespace DemoLinQ;

public class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return //!(x == null ^ y == null )&& 
            //x?.Id == y?.Id &&
            x?.Name.ToLower() == y?.Name.ToLower();
    }

    public int GetHashCode(Student obj)
    {
        return obj.GetHashCode();
    }
}