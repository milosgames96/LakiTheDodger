using System.Xml.Schema;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] float movespeed = 4f;
    [SerializeField] float rotationspeed = 100f;
    public static bool alive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lock the game to 160 fps
        Application.targetFrameRate = 160;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDog();
    }

    void MoveDog()
    {
        if (!alive) return;

        float xValue = 0f;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue, yValue, zValue);

        float angle = Input.GetAxis("Horizontal") * Time.deltaTime * rotationspeed;
        transform.Rotate(0f, angle, 0f);
    }
}
