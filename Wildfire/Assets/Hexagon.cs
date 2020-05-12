using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public int uCoordinate;
    public int vCoordinate;

    Vector3 u = new Vector3 (Mathf.Sin(30),0,Mathf.Cos(30));
    Vector3 v = new Vector3 (Mathf.Sin(30),0,-Mathf.Cos(30));

    public GameObject template;

    GameObject associatedPhysicalObject;
    
    public Hexagon(int uCount, int vCount) 
    { 
        uCoordinate = uCount;
        vCoordinate = vCount;

        associatedPhysicalObject = Instantiate(template);

        Vector3 position = u * uCoordinate + v * vCoordinate;
        associatedPhysicalObject.transform.position = position;
    } 
    
}

