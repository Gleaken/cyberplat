using Godot;

public partial class Camera2d : Camera2D
{
	[Export]
	private Node2D _follow;
	[Export]
	private int _tweenDistance = 100;
	

	public override void _Process(double delta)
	{
		if(_follow is null)
			return;

		if (!(Mathf.Abs(_follow.Position.X - Position.X) > _tweenDistance) &&
		    !(Mathf.Abs(_follow.Position.Y - Position.Y) > (_tweenDistance * .7))) return;
		var tween = GetTree().CreateTween();
		tween.TweenProperty(this, "position", new Vector2(_follow.Position.X, Position.Y), 0.8f);
	}
}
