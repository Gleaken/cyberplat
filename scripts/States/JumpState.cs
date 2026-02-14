using cyberplat.scripts;
using Godot;

[GlobalClass]
public partial class JumpState : Node, IState
{
	[Export]
	private AnimatedSprite2D _sprite;
	[Export]
	private CharacterBody2D _player;
	[Export]
	private Node _fallState;
	
	[Export]
	private float _jumpSpeed = 400;

	public override void _Ready()
	{
	}
	
	public void OnStateEnter()
	{
		_sprite.Play("jump_start");
		_player.Velocity = new Vector2(_player.Velocity.X, -_jumpSpeed);
	}

	public void OnStateExit() { }

	public string OnStateUpdate()
	{
		if(_player.Velocity.Y > 0) return _fallState.Name;
		return GetName();
	}

	public void OnStateFixedUpdate(double delta)
	{
		_player.Velocity = new Vector2(_player.Velocity.X, _player.Velocity.Y + 10);
	}

	public string GetName() => "JumpState";
}
