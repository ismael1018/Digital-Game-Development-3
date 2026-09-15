using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform player;
    public float moveSpeed;
    public Vector3 offset;
    public float followDistance;
    public Quaternion rotation;

    public float teleportDistanceThresHold = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > teleportDistanceThresHold)
        {
            transform.position = player.position + offset + -transform.forward * followDistance;
        }
        else {
            Vector3 pos = Vector3.Lerp(transform.position, player.position + offset + -transform.forward * followDistance, moveSpeed * Time.deltaTime);
            transform.position = pos;
        }

        transform.rotation = rotation;
    }
}
