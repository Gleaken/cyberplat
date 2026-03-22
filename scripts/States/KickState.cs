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
    [Export]
    private CollisionShape2D _rightKick;
    [Export]
    private CollisionShape2D _leftKick;
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

        if (_sprite.Frame == 4)
        {
             if(_sprite.FlipH)
                 _leftKick.Disabled = false;
             else
                 _rightKick.Disabled = false;
        }
        else
        {
            _leftKick.Disabled = true;
            _rightKick.Disabled = true;
        }
        return GetStateName();
    }

    public void OnStateFixedUpdate(double delta)
    {
    }

    public string GetStateName() => "KickState";
}