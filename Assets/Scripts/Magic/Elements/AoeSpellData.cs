using UnityEngine;
[CreateAssetMenu(fileName = "AoeSpellData", menuName = "Magic/Spells")]
public class AoeSpellData : BaseSpellData
{
    [SerializeField][Min(0)] private float m_radius;

    public float  radius => m_radius;
}
