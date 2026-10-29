namespace HelloInvestigation
{
	public class Greeting
	{
		public string Name { get; set; } = "";

		public string BuildMessage()
		{
			return "Hello, " + Name + "! Welcome to Sharksweeper.";
		}
	}
}
