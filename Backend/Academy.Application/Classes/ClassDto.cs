namespace Academy.Application.Classes
{
    public class ClassDto
    {
        public long Number { get;private set; }
        public string Title { get;private set; }

        public ClassDto(long number, string title)
        {
            Number = number;
            Title = title;
        }
    }
}