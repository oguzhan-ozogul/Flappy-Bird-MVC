using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    public PlayerModel playerModel;
    public PlayerView playerView;

    public PlayerController(PlayerView view)
    {
        playerView = view;
        playerModel = new PlayerModel();
        
      
    }
    public void BirdJump()
    {
        playerView.rb2D.velocity = playerModel.jumpPower * Vector2.up;
        

    }
    public void HeadUpDown()
    {
        playerView.gameObject.transform.eulerAngles = new Vector3(0, 0, playerView.rb2D.velocity.y * playerModel.headupdown);
    }



   
}
