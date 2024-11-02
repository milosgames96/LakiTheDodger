using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    public bool activeCollision = false;
    public float invinsibilityPeriod = 1f;
    public Color oldColor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null || activeCollision) return;
        else
        {
            //Debug.Log("COLLISION!!!");
            oldColor = GetComponent<MeshRenderer>().material.color;
            GetComponent<MeshRenderer>().material.color = Color.red;
            activeCollision = true;
            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(invinsibilityPeriod);
        activeCollision = false;
        GetComponent<MeshRenderer>().material.color = oldColor;
    }
}
