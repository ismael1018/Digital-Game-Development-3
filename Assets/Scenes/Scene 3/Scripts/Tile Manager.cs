using UnityEngine;
using System.Collections;
using NUnit.Framework.Constraints;

public class TileManager : MonoBehaviour
{
    // The tiles used for the puzzel
    public Tile[] tiles;
    public float showTime = 5f;

    public void ShowPath()
    {
        // starts the prcoess of shows tiles
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
