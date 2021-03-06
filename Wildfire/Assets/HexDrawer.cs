﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexDrawer : MonoBehaviour
{
    public int BoardSize;
    Vector3 u = new Vector3 (Mathf.Sin(30),0,Mathf.Cos(30));
    Vector3 v = new Vector3 (Mathf.Sin(30),0,-Mathf.Cos(30));
    public GameObject tile;
    public GameObject[,] array;

    
    // Start is called before the first frame update
    void Start()
    {
        int max = (BoardSize-1)/2;
        array = new GameObject[BoardSize,BoardSize];

        for (int ii=-max;ii<=max;ii++)
        {
            Debug.Log("\n");
            for (int jj=-max;jj<=max;jj++)
            {
                Debug.Log(ii.ToString()+", "+jj.ToString()+"    ");

                if (Mathf.Abs(ii+jj)<max+1)
                {

                    Vector3 newPosition = u * ii + v * jj;

                    GameObject newTile = Instantiate(tile);

                    newTile.transform.position = newPosition;

                    newTile.GetComponent<Coordinate>().uCoordinate=ii;
                    newTile.GetComponent<Coordinate>().vCoordinate=jj;
                    
                    array[ii+max,jj+max] = newTile;
                }
                
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}