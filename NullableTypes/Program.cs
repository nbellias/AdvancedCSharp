// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nullable Types");

bool hasAccess = true;
Nullable<DateTime> date = null;
DateTime? anotherDate = null;
DateTime date2;

Console.WriteLine(date.GetValueOrDefault());
Console.WriteLine(date.HasValue);
//Console.WriteLine(date.Value);

//Option A analytically or with tertiary operator
if(date != null)
{
    date2 = date.GetValueOrDefault();
} else
{
    date2 = DateTime.Today;
}
Console.WriteLine(date2);
//Option B with the null coalescing operator
DateTime date3 = date ?? DateTime.Today;
Console.WriteLine(date3);