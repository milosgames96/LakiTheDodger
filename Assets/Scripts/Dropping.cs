using UnityEngine;

public class Dropping : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;  
        rigidBody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!="Player")
            GetComponent<AudioSource>().Play();
    }
}
