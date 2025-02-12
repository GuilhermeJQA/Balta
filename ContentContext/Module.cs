namespace Balta.ContentContext
{
    public class Module : Base
    {

        public Module(string title)
        {
            Lectures = new List<Lecture>();
            Title = title;
        }
        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
    }
}