using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeTerrain : MonoBehaviour
{
    public GameObject hexTileTemplate;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Craig");

        Vector3 newPosition = new Vector3(5,0,0);

        GameObject newHex = Instantiate(hexTileTemplate);

        newHex.transform.position = newPosition;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
//HexTile_Sheet_1A_3
//X 90
