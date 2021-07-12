using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            // On the first line you will receive a title of an article. 
            string title = Console.ReadLine();
            // On the next line you will receive the content of that article.
            string content = Console.ReadLine();
            // On the next n lines until you receive "end of comments" you will get the comments about the article.
            List<string> commentsList = new List<string>();
            
            while (true)
            {
                string comments = Console.ReadLine();

                if (comments == "end of comments")
                {
                    break;
                }
                commentsList.Add(comments);
                
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            foreach (var comm in commentsList)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comm}");
                Console.WriteLine("</div>");
            }

        }
    }
}
