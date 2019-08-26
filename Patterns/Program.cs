using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Requirement requirement = new Requirement();

            ProgramManager christine = new ProgramManager();

            Architect todd = new Architect();

            SoftwareEngineer janet = new SoftwareEngineer();

            QAEngineer alex = new QAEngineer();

            DevOpsEngineer mike = new DevOpsEngineer();


            // introduce the team to each other
            christine.HandelOverWhenDone(todd);
            todd.HandelOverWhenDone(janet);
            janet.HandelOverWhenDone(alex);
            alex.HandelOverWhenDone(mike);

            //meet the client/program manager

            christine.Handle(requirement);

            //test
            foreach (var operation in requirement.OperationsDone)
            {
                Console.WriteLine($"{operation} -> Done");
            }
            
        }
    }
}
