using Godot;

namespace cyberplat.scripts.States;

[GlobalClass]
public partial class MoveState : Node, IState
{
    public void OnStateEnter()
    {
        
    }

    public void OnStateExit()
    {
        throw new System.NotImplementedException();
    }

    public string OnStateUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void OnStateFixedUpdate(double delta)
    {
        throw new System.NotImplementedException();
    }

    public string GetName() => "MoveState";
}