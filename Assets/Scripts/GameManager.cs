using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    PlayerModel playerModel;

    public Text ScoreText;
    

    void Start()
    {
        playerModel = new PlayerModel();
        playerModel.score = 0;
        //ScoreText.text = playerModel.score.ToString();
    }


    void Update()
    {

    }
    public void UpdateScore()
    {
        playerModel.score++;
        ScoreText.text = playerModel.score.ToString();

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Basla()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
