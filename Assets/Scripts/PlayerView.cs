using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerView : MonoBehaviour
{
    

    public Rigidbody2D rb2D;

    public bool isDead;

    public GameManager managerGame;
    public PlayerModel playerModel;

    public GameObject DeathScreen;

    private PlayerController playerController;
    

    private void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        playerController = new PlayerController(this);
    }



    void Update()
    {
        //Tuþ atamasý
        if (Input.GetMouseButtonDown(0))
        {
            //Havada kuþu sýçratma
            playerController.BirdJump();
        
        }
        playerController.HeadUpDown();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }






}
