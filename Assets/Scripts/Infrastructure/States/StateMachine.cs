using System.Collections.Generic;
using UnityEngine;
using System;

public class StateMachine 
{
    private IState m_state;
    private Dictionary<Type, IState> m_state = new();
    public void Initialize(IState[] state)
    {

    }
   public void ChangedState<T>()
        where T : IState
    {
        m_state?.Exit();
        {
            m_state = null;
        }
    }
}

public interface IState
{
    public void Enter();
    public void Exit();
}
public class MainMenuState : IState
{
    private StateMachine m_stateMachine;

    public MainMenuState (StateMachine stateMachine)
    {
        m_stateMachine = stateMachine;
    }
    public void Enter()
    {
        throw new NotImplementedException();
    }

    public void Exit()
    {
        throw new NotImplementedException();
    }
}