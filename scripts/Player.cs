using Godot;

public partial class Player : Node2D
{
	[Export]
	public InputComponent InputComponent { get; set; }
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		var direction = InputComponent.Direction;
		GD.Print(direction);
	}
}
