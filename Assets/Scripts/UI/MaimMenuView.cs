using System;
using UnityEngine;

public class MaimMenuView : MonoBehaviour
{
    public event Action PlayClicked;
    public event Action ExitClicked;

    [SerializeField] private GameObject m_playButton;
    [SerializeField] private GameObject m_exitButton;

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
    private void OnPlayClick => PlayClicked?.Invoke();
    private void OnExitClick => ExitClicked?.Invoke();

}
