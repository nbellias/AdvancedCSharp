// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dynamic");

object obj = "Nikos";
Console.WriteLine(obj.GetHashCode());

// Using reflection
// var methodInfo = obj.GetType().GetMethod("GetHashCode");
// Console.WriteLine(methodInfo.Invoke(null, null));

// DLR on CLR
// With dynamic we need to write more test to assure our
// application runs correctly.
dynamic myObj = new {
    Name = "Nikos",
    Registration = DateTime.Now
};

Console.WriteLine(myObj);
Console.WriteLine(myObj.Name);
Console.WriteLine(myObj.Registration);

//Implicit conversions
int i = 5;
dynamic d = i;
long l = d;

Console.WriteLine(l);
