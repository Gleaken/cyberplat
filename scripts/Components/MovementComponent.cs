using Godot;
using System;

[GlobalClass]
public partial class MovementComponent : Node
{
	[Export]
	private Node2D _controlledObject;
	[Export]
	private AnimatedSprite2D _sprite;
	
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}
}
