using Advanced_programming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_programming.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{Address = "33 Anning Road", Name = "Jack Gittoes", StartDate = DateTime.Now.AddDays(-1), NINumber = "PG92874571A", Branch = "Yeovil", TypeOfEmployee = "Hourly"},
                new Employee{Address = "14 Eastville", Name = "Curtis Guppy", StartDate = DateTime.Now.AddDays(-10), NINumber = "PG47386UA", Branch = "Yeovil", TypeOfEmployee = "Salaried"},
                new Employee{Address = "11 Rosemoor Gardens", Name = "Lucy Maskell", StartDate = DateTime.Now.AddDays(-20), NINumber = "PG96963AF", Branch = "London", TypeOfEmployee = "Commission"},
                new Employee{Address = "67 Sherborne Road", Name = "Aleks Moskal", StartDate = DateTime.Now.AddDays(-11), NINumber = "PG75489SA", Branch = "London", TypeOfEmployee = "Hourly"},
                new Employee{Address = "79 Marl Close", Name = "Avril Guppy", StartDate = DateTime.Now.AddDays(-5), NINumber = "PG86589PA", Branch = "Yeovil", TypeOfEmployee = "Commission"},
                new Employee{Address = "54 Cheap Street", Name = "Hugh Mungus", StartDate = DateTime.Now.AddDays(-24), NINumber = "PG65478GA", Branch = "London", TypeOfEmployee = "Salaried"},
                new Employee{Address = "85 London Road", Name = "John Smith", StartDate = DateTime.Now.AddDays(-30), NINumber = "PG54858da", Branch = "London", TypeOfEmployee = "Hourly"},
                new Employee{Address = "53 Bean Town", Name = "Jacob Mouncey", StartDate = DateTime.Now.AddDays(-35), NINumber = "PG85488GA", Branch = "Yeovil", TypeOfEmployee = "Salaried"},
            };
            employees.ForEach(s => context.Employee.Add(s));
            context.SaveChanges();
        }
    }
}
