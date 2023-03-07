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
	}
}

