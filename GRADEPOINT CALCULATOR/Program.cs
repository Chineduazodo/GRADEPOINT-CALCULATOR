Console.WriteLine("WELCOME TO THE GRADEPOINT CALCULATOR");

Console.Write("ENTER YOUR NAME: ");
Console.ReadLine();

Console.Write("ENTER YOUR DEPARTMENT: ");
Console.ReadLine();

Console.Write("ENTER MATRICULATION NUMBER: ");
Console.ReadLine();

Console.Write("ENTER COURSE NAME/CODE: ");
Console.ReadLine();

Console.Write("ENTER COURSE  CREDIT POINT: ");
Console.ReadLine();

Console.Write("ENTER SCORE: ");
int score = Convert.ToInt32(Console.ReadLine());

if (70 <= 100)
{
    Console.WriteLine("A");
    Console.WriteLine("EXCELLENT");
}
else if (60 <= 69)
{
    Console.WriteLine("B");
    Console.WriteLine("VERY GOOD");
}
else if (50 <= 59)
{
    Console.WriteLine("C");
    Console.WriteLine("GOOD");
}
else if (45 <= 49)
{
    Console.WriteLine("D");
    Console.WriteLine("FAIR");
}
else if (40 <= 44)
{
    Console.WriteLine("E");
    Console.WriteLine("PASS");
}
else if (0 <= 39)
{
    Console.WriteLine("F");
    Console.WriteLine("FAIL");
}
else
{
    Console.WriteLine("INPUT A VALID NUMBER,NUMBER OUT OF RANGE!");
}

