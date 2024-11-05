using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;
    [SerializeField] float speed = 1f;

    Vector3 playerPosition;
    void Start()
    {
        playerPosition = PlayerTransform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed*Time.deltaTime);
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
