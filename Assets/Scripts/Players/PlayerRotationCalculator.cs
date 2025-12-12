using UnityEngine;

public sealed class PlayerRotationCalculator : MonoBehaviour
{
   private readonly Camera m_camera;
   private readonly Transform m_Playertransform;

    public PlayerRotationCalculator(Camera camera, Transform m_playerTransform)
    {
        m_camera = camera;
        m_playerTransform = transform;
    }
    public Vector3 Calculate (Vector3 mousePosition)
    {
        var PlayerScreenPos = m_camera.WorldToScreenPoint(m_Playertransform.position);
        var delta = (Vector2)(mousePosition - PlayerScreenPos);

        var cameraRight = m_camera.transform.right;
        cameraRight.y = 0;
        cameraRight.Normalize();

        var cameraForward = m_camera.transform.forward;
        cameraForward.y = 0;
        cameraForward.Normalize();

        var worldDirectoin = cameraRight * delta.x + cameraForward * delta.y;
        worldDirectoin.y = 0;

        if(worldDirectoin.sqrMagnitude < 0.00001f)
        {
            return m_Playertransform.position + worldDirectoin;
        }
        return Vector3.zero;
    }
}
