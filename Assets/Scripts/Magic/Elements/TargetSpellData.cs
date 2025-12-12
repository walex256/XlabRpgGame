using UnityEngine;
[CreateAssetMenu(fileName = "TargetSpellData", menuName = "Magic/Spells")]

public class TargetSpellData : BaseSpellData
{
    [SerializeField][Min(0)] private float m_speed;

    public float speed => m_speed;
}

    
