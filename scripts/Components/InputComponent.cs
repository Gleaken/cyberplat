using Godot;

[GlobalClass]
public partial class InputComponent : Node
{
	public Vector2 Direction { get; private set; } = Vector2.Zero;
	public bool Jump { get; private set; }
	public bool Kick { get; private set; }

	public override void _Process(double delta)
	{
		Direction = Vector2.Zero;
		Jump = false;
		Kick = false;
		
		if(Input.IsActionPressed("move_right"))
			Direction += Vector2.Right;
		if(Input.IsActionPressed("move_left"))
			Direction += Vector2.Left;
		if(Input.IsActionPressed("move_up"))
			Direction += Vector2.Up;
		if(Input.IsActionPressed("move_down"))
			Direction += Vector2.Down;
		if (Input.IsActionPressed("jump"))
			Jump = true;
		if (Input.IsActionPressed("kick")) Kick = true;
	}
}
