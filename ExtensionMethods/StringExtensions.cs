using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ExtensionMethods
{
	//Microsoft: use extension methods when you really have to!
	//Create static class
	public static class StringExtensions
	{
		//Create static method with 'this <classname> object'
		public static string Shorten(this String str, int numberOfWords)
		{
			if(numberOfWords < 0)
			{
				throw new ArgumentOutOfRangeException("Number of words should be 0 or more.");
			}

			if(numberOfWords == 0)
			{
				return String.Empty;
			}

			var words = str.Split(' ');
			if(words.Length <= numberOfWords)
			{
				return str;
			}

			return string.Join(" ", words.Take(numberOfWords)) + "...";
		}

		//Another extension for user defined MyClass which returns a string with the properties of the object
		public static string PrintMyClass(this MyClass obj, string separator)
		{
            return obj.IntProperty.ToString() + separator + obj.StringProperty + separator + obj.DateTimeProperty.ToString();
        }

        //Yet another extension for user defined MyClass which returns a string with the properties of the object
        public static string PrintJSON(this MyClass obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }

	
}

