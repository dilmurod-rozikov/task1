Console.WriteLine("Enter your birth year: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("It's been " + CalculateAge(input) + " days from " + input + " till this year"); 

Console.WriteLine("Enter your radius: ");
double input1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Area: {AreaOfCircle(input1)}");

Console.WriteLine("Enter your radius: ");
double input2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Length: {LengthOfCircle(input2)}");

Console.WriteLine("Enter your amount of money: ");
double input3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"your money in sums : {ConvertCurrency(input3)}sum");

static double AreaOfCircle(double radius)
{
    return Math.Round(Math.PI * radius * radius, 2);
}

static double LengthOfCircle(double radius) 
{
    return Math.Round(2 * radius * Math.PI, 2);
}

static double ConvertCurrency(double amount)
{
    return amount * 12400;
}

static int CalculateAge(int year)
{
    int  date = DateTime.Now.Year;
    int ans = 0;
    while (year != date)
    {
        if (year % 4 == 0 && year % 100 != 0)
            ans += 366;
        ans += 365;
        year++;
    }
    return ans;
}