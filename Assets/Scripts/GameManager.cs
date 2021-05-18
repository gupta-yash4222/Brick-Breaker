using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;
    public int lives;
    public Text scoreText;
    public Text livesText;
    public bool gameplay;
    public GameObject panel;
    public GameObject panel2;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + score;
        livesText.text = "Lives : " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int change){
        lives = lives + change;
        livesText.text = "Lives : " + lives;
        if(lives <= 0){
            gameOver();
        }
    }

    public void UpdateScore(int change){
        score = score + change;
        scoreText.text = "Score : " + score;
        if(score == 33){
            gameWon();
        }
    }

    public void gameOver(){
        gameplay = true;
        panel.SetActive(true);
    }

    public void gameWon(){
        gameplay = true;
        panel2.SetActive(true);
    }
}
