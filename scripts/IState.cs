namespace cyberplat.scripts;

public interface IState
{
    void OnStateEnter();
    void OnStateExit();
    string OnStateUpdate();
    void OnStateFixedUpdate(double delta);
    string GetStateName();
}