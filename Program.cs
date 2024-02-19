////// See https://aka.ms/new-console-template for more information
////// to calculate BMI
////double weight = 60.5,
////    height = 1.72,
////    bmi;
////// calculate bmi
////bmi = weight / (height * height);
////Console.WriteLine($"BMI : {bmi :0.##}");

////datatypes
//sbyte signedbyte = 126;
//Console.WriteLine($"the min value of sbyte is {sbyte.MinValue}");
//Console.WriteLine($"the max value of sbyte is {sbyte.MaxValue}\n");
//byte unsignedbyte = 255;
//Console.WriteLine($"the min value of sbyte is {byte.MinValue}");
//Console.WriteLine($"the max value of sbyte is {byte.MaxValue}\n");
//short shortvalue = 32000;
//Console.WriteLine($"the min value of sbyte is {short.MinValue}");
//Console.WriteLine($"the max value of sbyte is {short.MaxValue}\n");
//ushort ushortvalue = 65000;
//Console.WriteLine($"the min value of sbyte is {ushort.MinValue}");
//Console.WriteLine($"the max value of sbyte is {ushort.MaxValue}\n");
//// GET TYPE
//String university = "karachi university";
//Console.WriteLine(university[8]);
//Console.WriteLine(university.IndexOf("u").GetType());
//Console.WriteLine(university.GetType());

// create program to convert currency dollar to pkr
//Console.WriteLine("Enter the number");
//var x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x* 278.59 + "pkr");
// declaring variables for operators
//int a = 9;
//a += 5;
//var b = 16;
//b -= 7;
//Console.WriteLine(a == b);
//Console.WriteLine(b);
//// logical and operator
//if(a == b & b ==a)
//{
//    Console.WriteLine("condition is true");

//}
//else
//{
//    Console.WriteLine("false condition");

//}
//// logical conditional and operator
//if (a == b && b == a)
//{
//    Console.WriteLine("condition is true");

//}
//else
//{
//    Console.WriteLine("false condition");

//}

//// logical OR operator
//if (a == b | b == a)
//{
//    Console.WriteLine("condition is true");

//}
//else
//{
//    Console.WriteLine("false condition");

//}
//// logical conditional OR operator
//if (a == b || b == a)
//{
//    Console.WriteLine("condition is true");

//}
//else
//{
//    Console.WriteLine("false condition");

//}

//// RAW STRING IN JSON
//var jsonn = """{"Name" : "wajiha","age":"28"}""";
//Console.WriteLine(jsonn);
// RAW STRING IN XML
//var XML = @"<books>
//<name>PHP</name>
//</books>";
//Console.WriteLine(XML);
//// RAW STRING INTERPOLATION IN JSONN
//var name = "wajiha";
//var jsonn = $$"""{"Name" : {{name}},"age":"28"}""";
//Console.WriteLine(jsonn);
//// to show variable path
//Console.WriteLine(@"c:\temp\no.txt");
//// to see the difference btw parse and int
//Console.WriteLine(Convert.ToInt32(8));
//Console.WriteLine(int.Parse(null)); // it will give exceptional error
//Nested IF
Console.WriteLine("Enter Your Age");
int age = Convert.ToInt32(Console.ReadLine());

//nested if
if (age >= 18)
{
    Console.WriteLine("Do You Have CNIC???");
    bool CNIC = Convert.ToBoolean(Console.ReadLine());
    if (CNIC == true)
    {
        Console.WriteLine("You are eligible to vote");
    }
    else
    {
        Console.WriteLine("CNIC bawalo");
    }
}
else
{
    Console.WriteLine("bary hojao");
}

//Else IF
Console.WriteLine("Select Day");
var Day = Convert.ToString(Console.ReadLine());

if (Day == "Monday")
{
    Console.WriteLine("GO to Aptech");
}
else if (Day == "Tuesday")
{
    Console.WriteLine("GO to Sleep");
}
else if (Day == "Wednesday")
{
    Console.WriteLine("GO to Market");
}
else if (Day == "Thursday")
{
    Console.WriteLine("GO to School");
}
else if (Day == "Friday")
{
    Console.WriteLine("GO to College");
}
else if (Day == "Saturday")
{
    Console.WriteLine("GO to University");
}
else if (Day == "Sunday")
{
    Console.WriteLine("GO to Park");
}
else
{
    Console.WriteLine("Go");
    //switch case
}
switch (day)
{
    case "Monday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "Tuesday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "wednesday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "Thurday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "friday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "Saturday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    case "Sunday":
        Console.WriteLine("Agaya monday sir dard");
        break;
    default:
        Console.WriteLine("Please Enter Correct Day");
        break;
}
