using System.Xml.Schema;
using UnityEngine;

public class Moving : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        Vector3 oldPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")*0.1f;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical")*0.1f;
        transform.Translate(xValue,yValue,zValue);
    }
}
