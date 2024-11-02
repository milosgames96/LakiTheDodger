using System.Collections;
using UnityEngine;

public class DogHit : MonoBehaviour
{
    private bool activeCollision = false;
    public float invinsibilityPeriod = 1f;
    private int score = 0;
    private int maxScore = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null || activeCollision) return;

        activeCollision = true;
        score++;
        Debug.Log("SCORE: "+score);
        StartCoroutine(Reset());
        GetComponent<AudioSource>().Play();

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
