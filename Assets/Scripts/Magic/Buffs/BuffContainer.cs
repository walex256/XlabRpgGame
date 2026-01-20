using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public sealed class BuffContainer 
{
    private HashSet<string> m_ids = new();
    private Dictionary<string,IBuff> m_buffs = new();

    private void Add(IBuff buff)
    {
        if (m_buffs.TryGetValue(buff.Id, out IBuff existingBuff))
        {
            existingBuff.Refresh(this);
        }
        else 
        {
            m_buffs.Add(buff.Id,buff);
            buff.Initialize(this);
        }
    }

    private void Remove(IBuff buff)
    {
        buff.Deinitialize();
        m_buffs.Remove(buff.Id);
    }

    public void Update()
    {
        foreach (var buff in m_buffs.Values)
        {
            buff.Update(Time.deltaTime);
        }
        foreach (var id in m_ids)
        {
            m_buffs.Remove(id);
        }

        m_ids.Clear();  
    }
}
