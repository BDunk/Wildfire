using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnHandler : MonoBehaviour
{
    private Text mComponent = null;
    // Start is called before the first frame update
    void Start()
    {
        mComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: consider using a full player object and dereference it
    public void handlePlayerNameUpdate(string playerName){
        Debug.Log("In the text handle update");
    
        mComponent.text = playerName;

    }
}
