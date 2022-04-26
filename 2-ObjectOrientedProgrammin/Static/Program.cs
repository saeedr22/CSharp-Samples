
using static System.DateTime;

SavingAccount s1 = new SavingAccount(50);
SavingAccount s2 = new SavingAccount(100);
// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingAccount.GetInterestRate());
// Make new object, this does NOT 'reset' the interest rate.
SavingAccount s3 = new SavingAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingAccount.GetInterestRate());
//Output
//Interest Rate is: 0.04
//Interest Rate is: 0.04
TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();

//A Simple Saving Account Class
class SavingAccount
{
    //instance-Level Data
    public double currBalance;
    // A static point of data.
    public static double currInterestRate = 0.04;
    public SavingAccount(double balance)
    {
        currBalance = balance;
    }

    static SavingAccount()
    {

        Console.WriteLine("OK! Static constructor");
    }

    public static void SetInterestRate(double InterestRate)
         => currInterestRate = InterestRate;

    public static double GetInterestRate()
            => currInterestRate;
}

// Static classes can only
// contain static members!

//notice this=> using static System.DateTime; => DateTime.Today.ToShortDateString() = Today.ToShortDateString()
static class TimeUtilClass
{
    public static void PrintTime()
    => Console.WriteLine(DateTime.Now.ToShortTimeString());
    public static void PrintDate()
    => Console.WriteLine(Today.ToShortDateString());
}

