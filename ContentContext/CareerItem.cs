using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public class CareerItem : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public string Description { get; set; }
        public CareerItem(string title, int order, string description, Course course)
        {
            if(course == null){
                AddNotification(new Notification("Course","Curso inválido"));
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}