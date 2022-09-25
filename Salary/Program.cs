using System;

namespace J
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int Salary = 0;

                Console.WriteLine("Enter your BRUTTO salary: ");
                Salary = Convert.ToInt32(Console.ReadLine());

                if (Salary >= 500 && Salary <= 1200)
                {
                    SalaryLessThan1200Eur(Salary);
                }

                if (Salary >= 1201 && Salary <= 2099)
                {
                    SalaryBetween1200And2100Eur(Salary);
                }

                if (Salary >= 2100)
                {
                    SalaryMoreThan2100Eur(Salary);
                }

            }

            static void SalaryLessThan1200Eur(double Salary)
            {
                double pensionFond = Salary * 0.02;

                double Insurance = Salary * 0.016;

                double Tax = (Salary - 500 - pensionFond - Insurance) * 0.2;

                double SalaryLessThan1200Eur = Salary - pensionFond - Insurance - Tax;

                SalaryLessThan1200Eur = Math.Round(SalaryLessThan1200Eur, 2);

                Console.WriteLine("Your NETTO salary is: " + SalaryLessThan1200Eur);
            }

            static void SalaryBetween1200And2100Eur(double Salary)
            {
                double pensionFond = Salary * 0.02;

                double Insurance = Salary * 0.016;

                double TaxFree = 500 - 0.55556 * (Salary - 1200);

                double Tax = (Salary - pensionFond - Insurance - TaxFree) * 0.2;

                double SalaryBetween1200And2100Eur = Salary - pensionFond - Insurance - Tax;

                SalaryBetween1200And2100Eur = Math.Round(SalaryBetween1200And2100Eur, 2);

                Console.WriteLine("Your NETTO salary is: " + SalaryBetween1200And2100Eur);
            }

            static void SalaryMoreThan2100Eur(double Salary)
            {
                double pensionFond = Salary * 0.02;

                double Insurance = Salary * 0.016;

                double Tax = Salary * 0.1928;

                double SalaryMoreThan2100Eur = Salary - pensionFond - Insurance - Tax;

                SalaryMoreThan2100Eur = Math.Round(SalaryMoreThan2100Eur, 2);

                Console.WriteLine("Your NETTO salary is: " + SalaryMoreThan2100Eur);
            }
        }
    }
}
