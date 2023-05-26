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
        Console.WriteLine("gdhdjd");
        break;
    default:
        Console.WriteLine("Wrong Input Entered");
        break;
   
}
