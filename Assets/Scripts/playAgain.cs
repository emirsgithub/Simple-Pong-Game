using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playAgain : MonoBehaviour
{
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject winText1;
    public GameObject winText2;

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    public int player1Score;
    public int player2Score;

    public void resetGame()
    {
        ball.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();


        playButton.SetActive(false);
        quitButton.SetActive(false);
        winText1.SetActive(false);
        winText2.SetActive(false);

    }

}
