using System.Xml.Schema;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] float movespeed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lock the game to 160 fps
        Application.targetFrameRate = 160;
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
