using System;

public class Payroll
{
    public decimal CalculateSalary(decimal baseSalary)
    {
        decimal tax = baseSalary * 0.18m;
        decimal bonus = baseSalary * 0.05m;
        return baseSalary - tax + bonus;
    }

    public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
    {
        decimal salary = hourlyRate * hoursWorked;
        salary = CalculateSalary(salary);
        return salary;
    }
}

class Program
{
    static void Main()
    {
        Payroll payroll = new Payroll();

        decimal baseSalary = 50000m;
        decimal fullTimeSalary = payroll.CalculateSalary(baseSalary);
        Console.WriteLine("Full-time salary: " + fullTimeSalary);

        // Para probar la modalidad de medio tiempo
        decimal hourlyRate = 20m;
        int hoursWorked = 40;
        decimal partTimeSalary = payroll.CalculateSalaryForPartTime(hourlyRate, hoursWorked);
        Console.WriteLine("Part-time salary: " + partTimeSalary);
    }
}
