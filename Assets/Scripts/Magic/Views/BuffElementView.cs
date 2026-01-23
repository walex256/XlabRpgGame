using UnityEngine;
using UnityEngine.UI;

public class BuffElementView : MonoBehaviour
{
    [SerializeField] private Image m_iconImage;
    [SerializeField] private Image m_timerImage;
    private IBuff m_buff;

    private void Initialize(IBuff buff)
    {
        gameObject.SetActive(true);
        m_buff = buff;
        m_iconImage.sprite = buff.Icon;
    }
    public void Deinitialize()
    {
        gameObject.SetActive(false);
    }
    private void Update()
    {
        
    }

}
