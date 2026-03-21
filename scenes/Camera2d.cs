using Godot;


public partial class Camera2d : Camera2D
{
	[Export]
	private Node2D _follow;
	// public override void _Ready()
	// {
	// }

	public override void _Process(double delta)
	{
		if(_follow is null)
			return;
		
		GD.Print("X diff: " + (_follow.Position.X - Position.X).ToString() );
		
		if(Mathf.Abs(_follow.Position.X - Position.X) > 100 || Mathf.Abs(_follow.Position.Y - Position.Y) > 100)
		{
			GD.Print("Camera2d: " + _follow.Position.ToString());
			Position = new Vector2(_follow.Position.X, _follow.Position.Y);
		}
	}
}
