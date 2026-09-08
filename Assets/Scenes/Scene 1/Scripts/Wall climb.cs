using UnityEngine;

public class Wallclimb : MonoBehaviour
{
    public float climbSpeed = 3f;
    public Transform orientation;
    public LayerMask wallLayer;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool onWall = Physics.Raycast(transform.position, orientation.forward, 1f, wallLayer);

        if (onWall && Input.GetKey(KeyCode.W))
        {
            rb.useGravity = false;
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, climbSpeed, rb.linearVelocity.z);
        }
        else
        {
            rb.useGravity = true;
        }
    }
}
