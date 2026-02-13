using Godot;

public partial class Player : Node2D
{
	[Export]
	public InputComponent InputComponent { get; set; }
	[Export]
	public AnimatedSprite2D Sprite { get; set; }
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		var direction = InputComponent.Direction;
		GD.Print(direction);
		
		if(direction.LengthSquared()>0)
			PlayRunAnimation();
		else
			PlayIdleAnimation();
	}
	
	public void PlayRunAnimation()
	{
		Sprite.Play("run");
	}
	
	public void PlayIdleAnimation()
	{
		Sprite.Play("idle");
	}
}
