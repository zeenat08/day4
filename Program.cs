using day4.UC10;
using day4.UC9;
using day4.UCLast_Final_Solution;
using System;


namespace day4
{
    class Program

    {
        public static void Main(string[] args)
        {
            // UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Airtel", 5, 10, 34);
            //  UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            // UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            // UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            // UC3_EmpWage.PartTimeEmpWage();
            //UC2_EmpWage.EmpWage();
            // UC1_EmployeeAttandance.GetAttendance();

            #region UC9
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            #endregion


            // #region UC10
            //.EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuilder.computeEmpWage();
            //#endregion


            //#region UCLast_Final_Solution
            //EmpWageBuilder empWageBuild = new EmpWageBuilder();
            //empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuild.computeEmpWage();
            //#endregion

            Console.ReadKey();
        }



    }
}
