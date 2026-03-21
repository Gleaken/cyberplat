using cyberplat.scripts;
using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public InputComponent InputComponent { get; set; }
	[Export]
	public AnimatedSprite2D Sprite { get; set; }
	[Export]
	public StateMachine StateMachine { get; set; }
	[Export]
	private float _gravity = 10;
	[Export]
	private float _fallSpeedMod = 3;

	
	private IState _currentState;
	private bool _stateChanged = false;
	public override void _Ready()
	{
		_currentState = StateMachine.States["IdleState"];
		_stateChanged = true;
	}

	public override void _Process(double delta)
	{
		if (_stateChanged)
		{
			_currentState.OnStateEnter();
			_stateChanged = false;
		}
		
		var nextState = _currentState.OnStateUpdate();
		if (nextState != _currentState.GetStateName())
		{
			_currentState.OnStateExit();
			_currentState = StateMachine.States[nextState];
			_stateChanged = true;
		}
		
		if(Velocity.X < 0)
			Sprite.FlipH = true;
		if(Velocity.X > 0)
			Sprite.FlipH = false;
	}

	public override void _PhysicsProcess(double delta)
	{
		_currentState.OnStateFixedUpdate(delta);
		MoveAndSlide();
	}
	
	public float FallSpeed => _gravity * _fallSpeedMod;
}
