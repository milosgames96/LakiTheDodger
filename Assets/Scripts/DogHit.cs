using System.Collections;
using UnityEngine;

public class DogHit : MonoBehaviour
{
    public bool activeCollision = false;
    public float invinsibilityPeriod = 1f;
    public int score = 0;
    public int maxScore = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null || activeCollision) return;

        activeCollision = true;
        score++;
        Debug.Log("SCORE: "+score);
        StartCoroutine(Reset());

        if (score >= maxScore)
        {
            transform.Rotate(180f, 0f, 0f);
            Moving.alive = false;
            Debug.Log("LAKI IS TIRED. GAME OVER");
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(invinsibilityPeriod);
        activeCollision = false;
    }
}
