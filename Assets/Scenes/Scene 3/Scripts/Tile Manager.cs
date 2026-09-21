using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour
{
    public Tile[] tiles;
    public float showTime = 5f;

    public void ShowPath()
    {
        StartCoroutine(ShowTiles());
    }

    IEnumerator ShowTiles()
    {
        // Show green and red tiles
        foreach (Tile tile in tiles)
        {
            tile.ShowColor();
        }

        // Wait
        yield return new WaitForSeconds(showTime);

        // Hide them again
        foreach (Tile tile in tiles)
        {
            tile.HideColor();
        }
    }
}
