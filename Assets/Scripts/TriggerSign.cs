using UnityEngine;

public class TriggerSign : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Ball!=null)
        {
            Ball.SetActive(true);
        }
    }
}
