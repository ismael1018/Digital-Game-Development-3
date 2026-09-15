using UnityEngine;
using System.Collections;

public class Diceroll : MonoBehaviour
{

    public int lastRoll;
    public float spinDuration = 1f;
    public float spinSpeed = 500f;

    public Vector3[] faceRotations = new Vector3[6];

    private bool isRolling = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRolling)
        {
            StartCoroutine(RollRoutine());
        }
    }

    private IEnumerator RollRoutine()
    {
        isRolling = true;

        float timer = 0f;
        while (timer < spinDuration)
        {
            transform.Rotate(spinSpeed * Time.deltaTime, spinSpeed * 0.7f * Time.deltaTime, spinSpeed * 0.5f * Time.deltaTime);
            timer += Time.deltaTime;
            yield return null;
        }

        lastRoll = Random.Range(1, 7); // 1 to 6
        transform.eulerAngles = faceRotations[lastRoll - 1];

        Debug.Log("Dice landed on: " + lastRoll);

        isRolling = false;
    }
}
