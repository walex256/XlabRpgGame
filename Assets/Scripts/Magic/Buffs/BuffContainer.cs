using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuffContainer : MonoBehaviour
{
    private Dictionary<string,IBuff> m_buffs = new();

    private void Add(IBuff buff)
    {
        if (m_buffs.TryGetValue(buff.Id, out IBuff existingBuff))
        {
            buff.Refresh();
        }
        else 
        {
            m_buffs.Add(buff.Id,buff);
            buff.Initialize();
        }
    }

    private void Remove(IBuff buff)
    {
        buff.Deinitialize();
        m_buffs.Remove(buff.Id);
    }
}
