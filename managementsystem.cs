using System;
public class LitwareLib
{
    private int EmpNo;
    private string EmpName;
    private double Salary;
    private double HRA;
    private double TA;
    private double DA;
    private double PF;
    private double TDS;
    private double NetSalary;
    private double GrossSalary;

    public void input(int EmpNo, string EmpName)
    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        
    }
    public void CalculateSalary(double Salary)
    {
        this.Salary = Salary;
        if (Salary < 5000)
        {
            this.HRA = 0.10 * Salary;
            this.TA = 0.05 * Salary;
            this.DA = 0.15 * Salary;

        }
        else if (Salary < 10000)
        {
            this.HRA = 0.15 * Salary;
            this.TA = 0.10 * Salary;
            this.DA = 0.20 * Salary;

        }
        else if (Salary < 15000)
        {
            this.HRA = 0.20 * Salary;
            this.TA = 0.15 * Salary;
            this.DA = 0.25 * Salary;

        }
        else if (Salary < 20000)
        {
            this.HRA = 0.25 * Salary;
            this.TA = 0.20 * Salary;
            this.DA = 0.30 * Salary;
        }
        else
        {

            this.HRA = 0.30 * Salary;
            this.TA = 0.25 * Salary;
            this.DA = 0.35 * Salary;
        } }
     public double CalcuGross()
        {
        
       this.GrossSalary = this.Salary + this.HRA + this.TA +this.DA;


        this.PF = 0.10 * this.GrossSalary;
        this.TDS = 0.18 * this.GrossSalary;
 

        return this.GrossSalary;
    }
    public double CalcuNet()
    {
       return  this.GrossSalary - this.PF + this.TDS;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        LitwareLib l = new LitwareLib();
        l.input(5, "rahul");
        l.CalculateSalary(100);
  Console.WriteLine("GrossSalary = {0} and NetSalary = {1}",l.CalcuGross(),l.CalcuNet());
    }
}