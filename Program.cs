Console.WriteLine("Enter your Choice\n1)uc1\n2)uc2\n3)uc3");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    //uc1
    case 1:
        int isPresent = 1;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        Console.WriteLine(empCheck);

        if(empCheck == isPresent)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is not  Present");
        }

        break;
    case 2:
        int is_full_time = 1;
        int emp_rate_per_hour = 20;

        int empHrs = 0;
        int empWage = 0;
        Random random1 = new Random();
        int empCheck1 = random1.Next(0, 2);
        Console.WriteLine(empCheck1);

        if (empCheck1 == is_full_time)
        {
            empHrs = 8;
        }
        else
        {
            empHrs = 0;
        }
        empWage = empHrs * emp_rate_per_hour;
        Console.WriteLine("Emp Wage " + empWage);
        break;
    default:
        Console.WriteLine("Wrong Input Entered");
        break;
   
}
