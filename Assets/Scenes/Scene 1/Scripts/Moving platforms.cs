using UnityEngine;

public class Movingplatforms : MonoBehaviour
{
    public float distance = 3f;
    public float speed = 2f;

    Vector3 startPos;
    bool goingRight = true;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goingRight)
            transform.position += Vector3.right * speed * Time.deltaTime;
        else
            transform.position -= Vector3.right * speed * Time.deltaTime;

        if(transform.position.x >  startPos.x + distance)
            goingRight = false;
        if(transform.position.x < startPos.x)
            goingRight = true;
    }

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            Destroy(Col.gameObject);
        }
    }
}
