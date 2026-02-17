using UnityEditor;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
        var stateMachine = new StateMachine();

        stateMachine.Initialize(
            new MainMenuState(stateMachine, MaimMenuView),
            new PauseMenuState(stateMachine),
            new DeadSatate(stateMachine),
            new GamePlayState(stateMachine, m_enemySpawner));

        stateMachine.ChangedState
    }
}
