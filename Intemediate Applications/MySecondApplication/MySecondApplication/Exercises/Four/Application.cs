using System;
using MySecondApplication.Exercises.Five;

namespace MySecondApplication.Exercises.Four
{
    public class Application
    {
        static void displayAnyKeyMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Press Any Key To Continue....");
            Console.ReadKey();
        }
        static bool validateConnection(DbConnection dbConnection)
        {
            if (dbConnection != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                SqlConnection sqlConnection = null;
                OracleConnection oracleConnection = null;
                DbConnection dbConnection = null;
                DbCommand dbCommand = null;

                int option = 0;

                while (option != 9)
                {
                    Console.WriteLine("---------------------  DBConnection --------------------------");
                    Console.WriteLine("Please enter the number for the option you want to perform:");
                    Console.WriteLine("- 1: Create SQL Connection");
                    Console.WriteLine("- 2: Open SQL Connection");
                    Console.WriteLine("- 3: Close SQL Connection");
                    Console.WriteLine("- 4: Create Oracle Connection");
                    Console.WriteLine("- 5: Open Oracle Connection");
                    Console.WriteLine("- 6: Close Oracle Connection");
                    Console.WriteLine("- 7: Create DB Command");
                    Console.WriteLine("- 8: Execute DB Command Created");
                    Console.WriteLine("- 9: Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("\n Please provide the connection string for the SQL Connection");
                                string sqlConnectionString = Console.ReadLine();
                                sqlConnection = new SqlConnection(sqlConnectionString);
                                break;
                            case 2:
                                if (validateConnection(sqlConnection))
                                {
                                    sqlConnection.OpenConnection();
                                }
                                else
                                {
                                    Console.WriteLine("\n Connection is not created yet");
                                }
                                break;
                            case 3:
                                if (validateConnection(sqlConnection))
                                {
                                    sqlConnection.CloseConnection();
                                }
                                else
                                {
                                    Console.WriteLine("\n Connection is not created yet");
                                }
                                break;
                            case 4:
                                Console.WriteLine("\n Please provide the connection string for the Oracle Connection");
                                string oracleConnectionString = Console.ReadLine();
                                oracleConnection = new OracleConnection(oracleConnectionString);
                                break;
                            case 5:
                                if (validateConnection(oracleConnection))
                                {
                                    oracleConnection.OpenConnection();
                                }
                                else
                                {
                                    Console.WriteLine("\n Connection is not created yet");
                                }
                                break;
                            case 6:
                                if (validateConnection(oracleConnection))
                                {
                                    oracleConnection.CloseConnection();
                                }
                                else
                                {
                                    Console.WriteLine("\n Connection is not created yet");
                                }
                                break;
                            case 7:
                                Console.WriteLine("\n Please enter the following information to create your DbCommand:");
                                Console.WriteLine("Type oracle or sql for the type of connection");
                                string typeOfConnection = Console.ReadLine();
                                Console.WriteLine("Provide the connection string");
                                string connectionString = Console.ReadLine();
                                Console.WriteLine("Provide the instruction");
                                string instruction = Console.ReadLine();

                                if (typeOfConnection.ToLower().Equals("sql"))
                                {
                                    dbConnection = new SqlConnection(connectionString);
                                }
                                else
                                {
                                    dbConnection = new OracleConnection(connectionString);
                                }
                                dbCommand = new DbCommand(dbConnection, instruction);

                                break;
                            case 8:
                                if (dbCommand != null)
                                {
                                    dbCommand.Execute();
                                }
                                else
                                {
                                    throw new Exception("The DbCommand is not initialized yet");
                                }

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

                    if (option != 9)
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

