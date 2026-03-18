using Godot;
using System;

[GlobalClass]
public partial class MovementComponent : Node
{
	[Export]
	private CharacterBody2D _controlledObject;
	[Export]
	private AnimatedSprite2D _sprite;
	[Export]
	private InputComponent _inputComponent;
	
	
	
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		var velocity = new Vector2(0, _controlledObject.Velocity.Y);
		_controlledObject.Velocity = new Vector2(_inputComponent.Direction.X * 50, _controlledObject.Velocity.Y);
	}
}
