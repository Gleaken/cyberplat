using Godot;
using cyberplat.scripts;

[GlobalClass]
public partial class IdleState : Node, IState
{
	[Export]
	private AnimatedSprite2D _sprite;
	[Export]
	private CharacterBody2D _player;
	[Export]
	private Node _fallState;

	public override void _Ready()
	{
	}
	
	public void OnStateEnter()
	{
		_sprite.Play("idle");
	}

	public void OnStateExit()
	{
	}

	public string OnStateUpdate()
	{
		if(!_player.IsOnFloor()) return _fallState.Name;
		return GetName();
	}

	public void OnStateFixedUpdate(double delta)
	{
	}

	public string GetName() => "IdleState";
}
