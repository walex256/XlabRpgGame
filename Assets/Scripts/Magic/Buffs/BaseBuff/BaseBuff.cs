using System;
using UnityEngine;

public class BaseBuff : IBuff
{
    public string Id {get; private set; }

    protected BuffContainer container { get; private set;}

    public void Deinitialize()
    {
        
    }
    public void Initialize(BuffContainer container)
    {
        this.container = container;
        OnInitialized();
    }

    protected virtual void OnInitialized()
    {
        
    }
}
