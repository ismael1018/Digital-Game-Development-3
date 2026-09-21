using UnityEngine;

public class TileCameraControl : MonoBehaviour
{
    
    public Transform player;

    public float moveSpeed = 5f;

    public Vector3 offset = new Vector3(0f, 6f, -6f);

    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );

        transform.LookAt(player);
    }
}