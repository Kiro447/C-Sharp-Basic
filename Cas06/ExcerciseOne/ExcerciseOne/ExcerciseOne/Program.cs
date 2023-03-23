using Domain.Classes;
using Domain.Enums;

Employee employee = new Employee()
{
    FirstName = "Kiril",
    LastName = "King",
    Role = RoleEnum.Manager,
};
Console.WriteLine(employee.GetInfo());
Console.WriteLine(employee.GetSalary());

int enumToInt = (int)employee.Role;
Console.WriteLine(enumToInt);


SalesPerson salesPerson = new SalesPerson("Zara", "Larson");
salesPerson.AddSuccessRevenue(400);
Console.WriteLine(salesPerson.GetSalary());


Manager manager = new Manager("Tom", "Cruise", 1200);
Console.WriteLine(manager.GetSalary());
manager.AddBonus(250);
Console.WriteLine(manager.GetSalary());