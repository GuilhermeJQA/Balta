using System;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "url.com"));
            articles.Add(new Article("Artigo sobre java", "java.com"));
            articles.Add(new Article("Artigo sobre javascript", "javascript.com"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("-------------------");
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Artigo sobre OOP", "url.com");
            var courseJava = new Course("Artigo sobre java", "java.com");
            var courseJavascript = new Course("Artigo sobre javascript", "javascript.com");
            courses.Add(courseJava);
            courses.Add(courseJavascript);
            courses.Add(courseOOP);

            var careers = new List<Career>();
            var careerdotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem("Comece por aqui", 1, "", courseJava);
            var careerItem2 = new CareerItem("Continue por aqui", 2, "", courseOOP);
            var careerItem3 = new CareerItem("Terceiro curso", 3, "", null);
            careerdotnet.Items.Add(careerItem);
            careerdotnet.Items.Add(careerItem2);
            careerdotnet.Items.Add(careerItem3);
            careers.Add(careerdotnet);

        
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
            var PayPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(PayPalSubscription);
        }
    }
}