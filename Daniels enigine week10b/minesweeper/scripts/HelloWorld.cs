using Godot;
using HelloInvestigation;

public partial class HelloWorld : Sprite2D
{
	public override void _Ready()
	{
		Greeting greeting = new Greeting();
		greeting.Name = "Ari";
		GD.Print(greeting.BuildMessage());
	}
}
has_mines
