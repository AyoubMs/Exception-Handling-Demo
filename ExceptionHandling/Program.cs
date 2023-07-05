


using ExceptionHandling;

int[] ages = new int[] { 1, 3, 5 };

try
{
    ExceptionHandlingMethods.BadCall(ages);
}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);
}

Console.ReadLine();