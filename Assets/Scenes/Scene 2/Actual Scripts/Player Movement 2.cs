using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float hopHeight = 5f;
    public float riseSpeed = 5f;
    private Collider col;
    private bool isLevitating;

    void Start()
    {
        col = GetComponent<Collider>();
    }
    void Update()
    {
        float moveX = 0f;

        if (Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.RightArrow))
        {
            moveX = 1f;
        }

        if (Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1f;
        }

        Vector3 movement = new Vector3(moveX, 0f, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;

        isLevitating =
            Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.UpArrow);

        if (isLevitating)
        {
            col.enabled = false;
        }

        float targetY = isLevitating ? hopHeight : 0f;

        Vector3 position = transform.position;

        position.y = Mathf.MoveTowards(
            position.y,
            targetY,
            riseSpeed * Time.deltaTime
        );

        transform.position = position;

        if (!isLevitating && Mathf.Abs(position.y) < 0.01f)
        {
            col.enabled = true;
        }
    }
}