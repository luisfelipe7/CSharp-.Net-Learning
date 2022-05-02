using System;
namespace MySecondApplication.Exercises.Two
{
  public class Application
  {
    static void displayAnyKeyMessage()
    {
      Console.WriteLine("");
      Console.WriteLine("Press Any Key To Continue....");
      Console.ReadKey();
    }

    static void Main(string[] args)
    {
      try {
        StackOverFlow stackOverFlow = new StackOverFlow();
        int option = 0;

        while (option != 4) {
          Console.WriteLine("---------------------  StackOverFlow --------------------------");
          Console.WriteLine("Please enter the number for the option you want to perform:");
          Console.WriteLine("- 1: Watch Posts");
          Console.WriteLine("- 2: Create Post");
          Console.WriteLine("- 3: Up/Down Vote Post");
          Console.WriteLine("- 4: Exit");
          option = Convert.ToInt32(Console.ReadLine());

          switch (option) {
            case 1:
              stackOverFlow.DisplayPosts();
              displayAnyKeyMessage();
              break;
            case 2:

              Console.WriteLine("\n To Create a Post please provide the following information:");
              Post postToAdd = new Post();

              Console.WriteLine("Title: ");
              postToAdd.Title = Console.ReadLine();
              Console.WriteLine("Description: ");
              postToAdd.Description = Console.ReadLine();

              stackOverFlow.AddPost(postToAdd);
              displayAnyKeyMessage();
              break;
            case 3:
              Console.WriteLine("\n Please enter the id of the post you want to vote:");
              int id = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter 1 if you want to Up Vote and -1 to Down Vote");
              int vote = Convert.ToInt32(Console.ReadLine());

              stackOverFlow.ModifyPost(id, vote);
              displayAnyKeyMessage();
              break;
          }

          Console.Clear();
        }


        Console.WriteLine("Thanks for using our application");

      } catch (Exception exception) {
        Console.WriteLine("Exception message: " + exception.Message);
      }
    }



  }
}
