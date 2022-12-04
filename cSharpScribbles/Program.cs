// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Program!");
/*
 calculate pay for a month. 
       Im interested in how it changes if you increase the per/hour

Monthly pay - per hour, hours
    method(22k) = per hour and hours(month)
    method(change per hour) = monthly pay, per hour and hours(month) 
 */
Pay myPay = new Pay();
myPay.whats_my_monthly_pay(110);

public class Pay
{
    public static int hoursPerMonth { get; set; } = 160;
    private float moneyPerHour;
    private float hours;

    private float moneyPerMonth;

    public void whats_my_hourly_pay(int monthlySalary) {
        moneyPerHour =(float) monthlySalary / (float)hoursPerMonth;  //is this float conversion needed?
        hours = hoursPerMonth;
        printPerHour(moneyPerHour, hours);
    }
    public void whats_my_monthly_pay(int payPerHour){
        moneyPerMonth = payPerHour * hoursPerMonth;
        printPerHour(moneyPerMonth, hoursPerMonth);
    }

    //should i learn overide string methods?
    private void printPerHour(float moneyPerHour, float hours)
    {
        Console.WriteLine($"{moneyPerHour}kr . {hours} hours.");
    }

}

/*
        C# 
          fundamentals - book with code
            
    school stuff(getting LIA, assignments)

    reading.. meditation and anailisum? neilisam?
 
 */