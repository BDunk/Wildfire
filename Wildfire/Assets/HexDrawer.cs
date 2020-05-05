using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexDrawer : MonoBehaviour
{
    public int BoardSize;
    // Start is called before the first frame update
    void Start()
    {
        int max = (BoardSize-1)/2;

        for (int ii=-max;ii<=max/2;ii++)
        {
            Debug.Log("\n");
            for (int jj=-max;jj<=max;jj++)
            {
                Debug.Log(ii.ToString()+", "+jj.ToString()+"    ");
                
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
