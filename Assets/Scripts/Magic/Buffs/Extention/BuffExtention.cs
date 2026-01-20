using Unity.VisualScripting;
using UnityEngine;

public static class BuffExtention 
{
    public static void Refresh(this IBuff buff)
    {
        buff.Deinitialize();
        buff.Initialize();
    }
}
