using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    void Update()
    {
        Vector3 oldPos = transform.position;
        if(Input.GetKey(KeyCode.RightArrow))
        {      
            transform.position = new Vector3(speed * Time.deltaTime,0,0) + oldPos;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(-speed * Time.deltaTime,0,0) + oldPos;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(0,0,speed * Time.deltaTime) +oldPos;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(0,0,-speed * Time.deltaTime)+oldPos;
        }
    }
}

