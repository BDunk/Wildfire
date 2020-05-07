using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class PlayerState {
    public string name;
}


public class GameManagement : MonoBehaviour
{
    public GameObject mNavFrame;

    private List<PlayerState> mPlayers = new List<PlayerState>();
    private int mCurrentPlayerOffset = -1;


    // Start is called before the first frame update
    void Start()
    {   
        PlayerState player = null;
        player = new PlayerState();
        player.name = "Bob";
        mPlayers.Add(player);
        player = new PlayerState();
        player.name = "Mai";
        mPlayers.Add(player);

        mCurrentPlayerOffset = 0;

        SendStateToNavFrame();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleDoneTurn()
    {
        Debug.Log("Hello from Craig in done turn");
        mCurrentPlayerOffset = (mCurrentPlayerOffset + 1) % (mPlayers.Count);
        SendStateToNavFrame();


    }

    private void SendStateToNavFrame()
    {
        PlayerState currentPlayer = mPlayers[mCurrentPlayerOffset];

        mNavFrame.BroadcastMessage("handlePlayerNameUpdate", currentPlayer.name );
    }

}
