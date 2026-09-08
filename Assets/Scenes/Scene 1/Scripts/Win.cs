using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI winText;

    
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
