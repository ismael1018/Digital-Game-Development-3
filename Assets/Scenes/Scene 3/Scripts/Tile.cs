using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isSafe;

    public Material safeMaterial;
    public Material dangerMaterial;
    public Material hiddenMaterial;

    private Renderer tileRenderer;

    void Start()
    {
        tileRenderer = GetComponent<Renderer>();
        HideColor();
    }

    public void ShowColor()
    {
        if (isSafe)
        {
            tileRenderer.material = safeMaterial;
        }
        else
        {
            tileRenderer.material = dangerMaterial;
        }
    }

    public void HideColor()
    {
        tileRenderer.material = hiddenMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isSafe && other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().PlayerDied();
            other.gameObject.SetActive(false);
        }
    }
}