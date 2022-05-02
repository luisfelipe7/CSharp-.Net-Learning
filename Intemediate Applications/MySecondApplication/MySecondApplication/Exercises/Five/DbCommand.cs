using System;
using MySecondApplication.Exercises.Four;

namespace MySecondApplication.Exercises.Five
{
    public class DbCommand
    {
        protected DbConnection DbConnection;
        protected string Instruction;

        public DbCommand()
        {
            Console.WriteLine("\n Constructor without parameters, initializing the elements required");
            this.DbConnection = null;
            this.Instruction = null;
        }

        public DbCommand(DbConnection dbConnection, string instruction) : this()
        {
            Console.WriteLine("Constructor with parameters, setting the DbConnection");
            if (dbConnection != null)
            {
                this.DbConnection = dbConnection;
                Console.WriteLine("DbConnection assigned sucessfully");

                if (!(String.IsNullOrEmpty(instruction)))
                {
                    this.Instruction = instruction;
                    Console.WriteLine("Instruction assigned sucessfully");
                }
                else
                {
                    throw new ArgumentNullException("The DbConnection can't be null");
                }
            }
            else
            {
                throw new ArgumentNullException("The DbConnection can't be null");
            }
        }

        public void Execute()
        {
            if ((this.DbConnection != null) && (String.IsNullOrEmpty(this.Instruction) != true))
            {
                Console.WriteLine("\n Starting the execution of the instruction");

                // Open Connection
                this.DbConnection.OpenConnection();


                // Run the Instruction
                Console.WriteLine("\n Executing the instruction: ");
                Console.WriteLine(this.Instruction);
                Console.WriteLine("Instruction executed sucessfully");


                // Close the Connection
                this.DbConnection.CloseConnection();
            }
            else
            {
                throw new Exception("There is a problem, the DbConnection or the Instruction are not defined yet");
            }

        }


    }
}

