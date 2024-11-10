using UnityEngine;

public class TriggerSign : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    private void Start()
    {
        Ball.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Ball!=null)
        {

            Ball.SetActive(true);
            Shooting.playerPosition = other.transform.position;
        }
    }
}
