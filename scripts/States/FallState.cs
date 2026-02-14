using Godot;
using cyberplat.scripts;

[GlobalClass]
public partial class FallState : Node, IState
{
	[Export]
	private AnimatedSprite2D _sprite;
	[Export]
	private CharacterBody2D _player;
	[Export]
	private float _fallSpeed = 10;
	[Export]
	private Node _idleState;
	
	private bool _isFalling = false;
	
	public void OnStateEnter()
	{
		if (_isFalling)
			return;
		
		_isFalling = true;
		_sprite.Play("jump_fall");
	}

	public void OnStateExit() { }

	public string OnStateUpdate()
	{
		if (_player.IsOnFloor()) return _idleState.Name;
		return GetName();
	}

	public void OnStateFixedUpdate(double delta)
	{
		_player.Velocity = new Vector2(_player.Velocity.X, _player.Velocity.Y + _fallSpeed);
	}

	public string GetName() => "FallState";
}
