using UnityEngine;

public class TIleTrigger : MonoBehaviour
{
    public TileManager tileManager;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !activated)
        {
            activated = true;
            tileManager.ShowPath();
        }
    }
}
