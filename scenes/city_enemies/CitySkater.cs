using Godot;

public partial class CitySkater : CharacterBody2D, IEnemy
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	
	private AnimatedSprite2D _sprite;
	
	public override void _Ready()
	{
		_sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(double delta)
	{
		if (!_sprite.IsPlaying())
			_sprite.Play("idle");
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}
		
		Velocity = velocity;
		MoveAndSlide();
	}

	public void OnInputEvent(Node body, InputEvent @event, int shapeIdx)
	{
		GD.Print("InputEvent");
	}

	public void Hit(int damage)
	{
		GD.Print($"Hit for {damage} damage");
		_sprite.Offset = new Vector2(6, 0);
		_sprite.Play("death");
	}
}

public interface IEnemy
{
	void Hit(int damage);
}
