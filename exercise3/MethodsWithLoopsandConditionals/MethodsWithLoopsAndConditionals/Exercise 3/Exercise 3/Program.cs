#region LukeWarm Section
Console.WriteLine(" This should print numbers 1000 through -1000");
PrintNumbers();
Console.WriteLine("This should count by three's from 3 through 999");
CountByThrees();
Console.WriteLine("This should tell you if the two numbers are equal or not");
Console.WriteLine(IsEqual(3, 6));
Console.WriteLine("This should return if the number is even or odd and positive or negative \nPlease type a number you want to check.");
EvenOrOdd(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Please enter your age.");
CanVote(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(" Please Enter a number between -10 and 10.");
NumberRange(Convert.ToInt32(Console.ReadLine()));

// Write a method that will print to the console all numbers 1000 through -1000 =====================
static void PrintNumbers()
{
    for (int a = 1000; a >= -1000; a--)
    {
        Console.WriteLine(a);
    }
}
// Write a method that will print to the console numbers 3 through 999 by 3 each time ===============
static void CountByThrees()
{
    for(int t = 3; t <= 999; t += 3)
    Console.WriteLine(t);
}
// Write a method to accept two integers as parameterss and check whether they are equal or not =====
static bool IsEqual(int d, int e)
{
    var checknumbers = (d == e);
    return checknumbers;
    
}
// Write a method to check whether a given number is even or odd ====================================
// Write a method to check whether a given number is positive or negative ===========================
static void EvenOrOdd(int number)
{
    if (number % 2 == 0 && number < 0)
    {
        Console.WriteLine("even" + " " + "negative");
    }
    else if (number % 2 == 0 && number > 0)
    {
        Console.WriteLine("even" + " " + "positive");
    }
    else if (number % 2 == 1 && number > 0)
    {
        Console.WriteLine("odd" + " " + "positive");
    }
    else if (number % 2 == 1 && number < 0)
    {
        Console.WriteLine("odd" + " " + "negative");
    }
    else if (number == 0)
    {
        Console.WriteLine("0");
    }
}

    // Write a method to read the age of a candidate and determine whether they can vote. ===============
    static void CanVote(int age)
{
    if (age <= 17)
    {
        Console.WriteLine("Sorry you Can not vote.");
    }
    else
    {
        Console.WriteLine("Congratulations you can vote!");
    }
}

#endregion
#region Getting Warm Section
// Write a method to check if an integer (from the user) is in the range -10 to 10 ==================
    static string NumberRange(int y)
{
    return (-10 <= y && y <= 10)?"yes":"no";
    //(condition?[true value] : [false value]
}

    int i, num;
    // Write a method to display the multiplication table (from 1 to 12) of a given integer =============
    Console.WriteLine("This will print a multiplication table for the entere'd number.\nPlease enter a number to print a Multiplication table: ");
    num = Convert.ToInt32(Console.ReadLine());

    for (i = 1; i <= 12; i++)
    {
        Console.Write("{0} X {1} = {2} \n", num, i, num * i);
    }
    #endregion
        