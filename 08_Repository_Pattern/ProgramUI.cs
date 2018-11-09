using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern
{
    public class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {

                Console.WriteLine("Choose an action:" +
                    "\n\t1. Create new show" +
                    "\n\t2. See current list" +
                    "\n\t3. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:     //Create a new show
                        CreateContent();
                        break;
                    case 2:     //Show current list
                        PrintContentList();
                        break;
                    case 3:     //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid response");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void CreateContent()
        {
            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("What the title?");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("What the genre?");
            newContent.Genre = Console.ReadLine();

            Console.WriteLine("How you rate this (1-5)?");
            newContent.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine("Is this contain mature content (y/n)?");
            string response = Console.ReadLine();
            if (response == "y")
            {
                newContent.IsMature = true;
            }
            else
            {
                newContent.IsMature = false;
            }

            _contentRepo.AddContentToList(newContent);
        }

        private void PrintContentList()
        {
            foreach (StreamingContent content in _contentRepo.GetContentList())
            {
                Console.WriteLine(content.Title);
            }
        }
    }
}
