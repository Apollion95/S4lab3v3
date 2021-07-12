using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ScaffoldModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using var ctx = new NorthwindContext();
            ctx.Add(new Employee() {  LastName = "Kowalski", Address = "Laczna 15", PostalCode="2222"});
            Console.WriteLine(ctx.ChangeTracker.DebugView);
            //ctx.SaveChanges();
        }
    }
}
//The entity type 'Employee' was not found. Ensure that the entity type has been added to the model.”