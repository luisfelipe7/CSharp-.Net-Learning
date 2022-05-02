using System;
namespace MySecondApplication.Exercises.Six
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
            try
            {
                Workflow workflow = new Workflow();
                WorkflowEngine workflowEngine = new WorkflowEngine(workflow);
                IActivity activity = null;

                int option = 0;

                while (option != 7)
                {
                    Console.WriteLine("---------------------  Workflow Engine --------------------------");
                    Console.WriteLine("Please enter the number for the option you want to perform:");
                    Console.WriteLine("- 1: Run Workflow");
                    Console.WriteLine("- 2: Add Upload Video Activity");
                    Console.WriteLine("- 3: Add Ready Video Activity");
                    Console.WriteLine("- 4: Add Send Email Activity");
                    Console.WriteLine("- 5: Add Processing Video Activity");
                    Console.WriteLine("- 6: Clear Activities");
                    Console.WriteLine("- 7: Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        switch (option)
                        {
                            case 1:
                                workflowEngine.Run();
                                break;
                            case 2:
                                activity = new UploadVideoActivity();
                                break;
                            case 3:
                                activity = new ReadyVideoActivity();
                                break;
                            case 4:
                                activity = new SendEmailActivity();
                                break;
                            case 5:
                                activity = new ProcessVideoActivity();
                                break;
                            case 6:
                                workflowEngine.getWorkFlow().ClearActivities();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid option");
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("\n Unexpected error ocurred, message: " + exception.Message);
                    }

                    if (option >= 2 && option <= 5)
                    {
                        workflowEngine.getWorkFlow().AddActitivity(activity);
                        activity = null;
                        Console.WriteLine("The activity were added sucessfully");
                    }

                    if (option != 7)
                    {
                        displayAnyKeyMessage();
                    }

                    Console.Clear();
                }


                Console.WriteLine("Thanks for using our application");

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception message: " + exception.Message);
            }
        }



    }
}

