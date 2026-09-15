using UnityEngine;

public class Wintrigger : MonoBehaviour
{
    public GameObject winScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winScreen.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Won!");

            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
