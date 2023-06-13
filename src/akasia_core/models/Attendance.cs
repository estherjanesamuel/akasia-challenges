namespace akasia_core.models;

public class Attendance
{
    public int ID { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string NIM { get; set; } = string.Empty;
}