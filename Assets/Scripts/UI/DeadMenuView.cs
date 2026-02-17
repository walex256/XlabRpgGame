using UnityEngine;
using UnityEngine.UI;

public class DeadMenuView : MonoBehaviour
{
    [SerializeField] private Button m_goToMenuButton;

    private void OnEnable()
    {
        m_goToMenuButton.onClick.AddListener(OnClicked);
    }
    private void OnDisable()
    {
        
    }
}
