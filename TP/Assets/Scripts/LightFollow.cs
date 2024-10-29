using UnityEngine;

public class LightFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + player.rotation * offset;
        transform.position = desiredPosition;
    }
}