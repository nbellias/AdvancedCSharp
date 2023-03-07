// See https://aka.ms/new-console-template for more information
using ExceptionHandling;

Console.WriteLine("...Exception Handling...");

// Catch excetions from most specific to most generic
var calculator = new Calculator();
try
{
    var result = calculator.Divide(5, 9);
    if (result == 0)
        throw new ArithmeticException();
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException, Cannot divide by zero.");
}
catch (ArithmeticException ex)
{
    Console.WriteLine("ArithmeticException, An Arithmetic Exception.");
}
catch (Exception ex)
{
    Console.WriteLine("Exception, Other Exception.");
}

//Finally option 1
StreamReader streamReader = null;
try
{
    streamReader = new StreamReader(@"file.zip");
    var content = streamReader.ReadToEnd();
    throw new Exception("Oops");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    if(streamReader != null)
        streamReader.Dispose();
}

//Finally option 2
try
{
    //'using' implicitly executes a finally block calling
    // the dispose method of StreamReader
    using (var streamReader2 = new StreamReader(@"file.zip"))
    {
        var content = streamReader2.ReadToEnd();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    var api = new YouTubeApi();
    var videos = api.GetVideos("Star Wars Andor");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


