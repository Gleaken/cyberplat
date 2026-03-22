using Godot;

namespace cyberplat.scripts;

[GlobalClass]
public partial class KickState : Node, IState
{
    [Export]
    private AnimatedSprite2D _sprite;
    [Export]
    private CharacterBody2D _player;
    [Export]
    private Node _idleState;
    // [Export]
    // private InputComponent _inputComponent;
    
    public void OnStateEnter()
    {
        _sprite.Play("kick");
    }

    public void OnStateExit()
    {
    }

    public string OnStateUpdate()
    {
        if(!_sprite.IsPlaying())
            return _idleState.Name;
        return GetStateName();
    }

    public void OnStateFixedUpdate(double delta)
    {
    }

    public string GetStateName() => "KickState";
}