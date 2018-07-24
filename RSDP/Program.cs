
using System;

 using System.Data.Entity;
 

namespace RSDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());
            var t = new Train
            {
                TrainID = "2",
                TrainType = 0,
                TrainFreightType = 0,
                TrainRunningSituatio = 0

            };
            using (var ctx = new OracleDbContext())
            {
                
                ctx.Train.Add(t);
                ctx.SaveChanges();
                Console.Write("Press any key to continue... ");
                Console.ReadLine();
            }
        }
    }
    


    
}
