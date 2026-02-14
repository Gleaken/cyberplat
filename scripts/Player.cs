using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public InputComponent InputComponent { get; set; }
	[Export]
	public AnimatedSprite2D Sprite { get; set; }
	
	private float _gravity = 10;
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		var direction = InputComponent.Direction;
	}

	public override void _PhysicsProcess(double delta)
	{
		var velocity = Velocity;
		
		if(!IsOnFloor())
			velocity.Y += _gravity;
		Velocity = velocity;
		if(Velocity.Y > 0)
			PlayJumpFallAnimation();
		else
			PlayIdleAnimation();
		MoveAndSlide();
	}

	public void PlayRunAnimation()
	{
		Sprite.Play("run");
	}
	
	public void PlayJumpFallAnimation()
	{
		Sprite.Play("jump_fall");
	}

	
	public void PlayIdleAnimation()
	{
		Sprite.Play("idle");
	}
}
