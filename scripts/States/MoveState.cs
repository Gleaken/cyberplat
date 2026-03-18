using Godot;

namespace cyberplat.scripts;

[GlobalClass]
public partial class MoveState : Node, IState
{
    [Export]
    private AnimatedSprite2D _sprite;
    [Export]
    private CharacterBody2D _player;
    [Export]
    private Node _idleState;
    [Export]
    private Node _fallState;
    [Export]
    private Node _jumpState;
    [Export]
    private InputComponent _inputComponent;
    
    public void OnStateEnter()
    {
        _sprite.Play("run");
    }

    public void OnStateExit()
    {
    }

    public string OnStateUpdate()
    {
        if(_player.IsOnFloor() && _inputComponent.Jump) return _jumpState.Name;        
        if(!_player.IsOnFloor())
            return _fallState.Name;
        if(_player.Velocity.X == 0)
            return _idleState.Name;
            
        return GetStateName();
    }

    public void OnStateFixedUpdate(double delta)
    {
    }

    public string GetStateName() => "MoveState";
}