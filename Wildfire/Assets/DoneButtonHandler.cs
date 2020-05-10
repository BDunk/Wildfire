using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class DoneButtonHandler : MonoBehaviour
{
    public Button mDoneButton;
    public GameManagement mGameManagement;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = mDoneButton.GetComponent<Button>();
		btn.onClick.AddListener(HandleOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandleOnClick()
    {
        mGameManagement.HandleDoneTurn();
    }
}
