// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("...Strings...");

/*
 * 
 * String is a reference type that behaves like a Value type variable.
 * Being a reference types implies, that the value of a string variable is NOT the actual data, 
 * but a pointer/reference to the actual data.
 * From MSDN: Although string is a reference type, the equality operators (== and !=) 
 * are defined to compare the values of string objects, not references.
 * This makes testing for string equality more intuitive.
 * 
 * This means that we might expect that comparing two strings with == or != compares to the references/pointers of the actual data.
 * But it does not. It directly compares the actual data they are assigned.
 * There is a term called immutable, which means the state of an object can't be changed after is has been created.
 * 
 * A string is an immutable type.
 *
 * The statement that a string is immutable means that, once created, it is not altered by changing the value assigned to it.
 * 
 * If we try to change the value of a string by concatenation (using + operator) or assign a new value to it, 
 * it actually results in creation of a new string object to hold a reference to the newly generated string. 
 * It might seem that we have successfully altered the existing string. 
 * But behind the scenes, a new string reference is created, which points to the newly created string.
 * 
 *  * From the above discussion, it becomes very important to understand that string operations, especially for large string manipulation,
 *  should be done very carefully.
 *  As an alternative, we have the StringBuilder class, which is much more efficient then string.
 *  Using its Append(), it always manipulates the existing string rather then creating a new instance.
 *  Thus, when we would like to append a large string, we should prefer the use of the StringBuilder class instead of the string class.
 *  
 */

string s1 = "Nikos";
string s2 = s1;
s2 += " Bellias";

Console.WriteLine("Actual data of string are equal? " + (s1 == s2 ? true : false));
Console.WriteLine($"s1={s1}, s2={s2}");
Console.WriteLine("Are the values (pointer to data) of string same? " + (object.ReferenceEquals(s1, s2)));


ChangeStringValue();

Console.WriteLine($"s1={s1}, s2={s2}\n");

UseStringBuilder();

void ChangeStringValue()
{
    s2 += ", son of Spyros";
}

void UseStringBuilder()
{

    StringBuilder str1 = new StringBuilder("One ");
    Console.WriteLine($"{str1}\n");
    str1.AppendLine("Two ");
    Console.WriteLine($"{str1}");
    str1.AppendFormat("{0:C} ", 50);
    Console.WriteLine($"{str1}");
    StringBuilder str2 = new StringBuilder("Hello World");
    str2 = str1;
    Console.WriteLine($"str1={str1}, str2={str2}");
    str2.AppendLine(" and You");
    Console.WriteLine($"str1={str1}, str2={str2}");
}

