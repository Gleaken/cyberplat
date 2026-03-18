using Godot;
using System.Collections.Generic;
using cyberplat.scripts;

[GlobalClass]
public partial class StateMachine : Node
{
	public Dictionary<string, IState> States { get; private set; } = new Dictionary<string, IState>();
	public override void _Ready()
	{
		var childs = GetChildren();
		foreach (var child in childs)
		{
			if (child is IState state)
				States.Add(state.GetStateName(), state);
		}
	}
}
