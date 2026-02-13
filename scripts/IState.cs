namespace cyberplat.scripts;

public interface IState
{
    void OnStateEnter();
    void OnStateExit();
    void OnStateUpdate();
    void OnStateFixedUpdate();
}