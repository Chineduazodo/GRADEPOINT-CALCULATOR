//WELCOME THE USER TO THE GRADEPOINT CALCULATOR
Console.WriteLine("WELCOME TO THE GRADEPOINT CALCULATOR");

//COLLECT USER'S DETAILS
Console.Write("ENTER YOUR NAME: ");
Console.ReadLine();

Console.Write("ENTER YOUR DEPARTMENT: ");
Console.ReadLine();

Console.Write("ENTER MATRICULATION NUMBER: ");
Console.ReadLine();

decimal totalWeightPoint = 0;
decimal totalCreditUnit = 0;
int gradeUnit = 0;
int courseUnit = 0;

//HERE ALLOWS  FOR MULTIPLE CHECKS
while(true)
    {

    Console.Write("ENTER COURSE NAME/CODE: ");
    Console.ReadLine();

    Console.Write("ENTER COURSE  CREDIT: ");
   courseUnit = Convert.ToInt32(Console.ReadLine());

    Console.Write("ENTER SCORE: ");
    int score = Convert.ToInt32(Console.ReadLine());

    //HERE CREATES A RANGE OF VALUES TO BE ACCEPTED AND USED FOR GRADING
    if (score < 0 || score > 100)
    {
        Console.WriteLine("Invalid input");
        continue;

    }

    //HERE GIVES THE SCORE RANGES WITH THEIR APPROPRIATE GRADE POINTS
    if (score >= 70 && score <= 100)
    {
        Console.WriteLine("A");
        Console.WriteLine("EXCELLENT");
        gradeUnit = 5;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else if (score >= 60 && score <= 69)
    {
        Console.WriteLine("B");
        Console.WriteLine("VERY GOOD");
         gradeUnit = 4;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else if (score >= 50 && score <= 59)
    {
        Console.WriteLine("C");
        Console.WriteLine("GOOD");
         gradeUnit = 3;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else if (score >= 45 && score <= 49)
    {
        Console.WriteLine("D");
        Console.WriteLine("FAIR");
        gradeUnit = 2;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else if (score >= 40 && score <= 44)
    {
        Console.WriteLine("E");
        Console.WriteLine("PASS");
        gradeUnit = 1;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else if (score >= 0 && score <= 39)
    {
        Console.WriteLine("F");
        Console.WriteLine("FAIL");
        gradeUnit = 0;
        Console.WriteLine($"GRADE UNIT: {gradeUnit}");
        Console.WriteLine($"COURSE UNIT: {courseUnit}");
    }
    else
    {
        Console.WriteLine("INPUT A VALID NUMBER,NUMBER OUT OF RANGE!");
        return;
        
    }
    
    decimal weightPoint = gradeUnit * courseUnit;
    totalWeightPoint += weightPoint;
    Console.WriteLine("WEIGHTPOINT: " + weightPoint);

    totalCreditUnit += courseUnit;

    Console.WriteLine("DO YOU WANT TO PERFORM ANOTHER CHECK? YES/NO");
    string answer = Console.ReadLine().ToUpper();
    if (answer == "NO")
    {
        Console.WriteLine("EXIT");
        break;
    }
}

decimal gpa = totalWeightPoint / totalCreditUnit;
Console.WriteLine($"GPA: {gpa}");

