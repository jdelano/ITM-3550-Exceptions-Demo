using System;
namespace ExceptionsDemo2024
{
	public class InvalidPriceRangeException : Exception
	{
		public InvalidPriceRangeException()
			:base("Invalid price range specified.")
		{
		}

		public InvalidPriceRangeException(string message)
			:base(message)
		{

		}

		public InvalidPriceRangeException(string message, Exception exception)
			:base(message, exception)
		{

		}
	}
}

