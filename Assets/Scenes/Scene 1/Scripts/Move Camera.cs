using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform cameraPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
