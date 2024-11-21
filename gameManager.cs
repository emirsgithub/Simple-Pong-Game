using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
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

    private int player1Score;
    private int player2Score;

    public GameObject playButton;
    public GameObject quitButton;
    public GameObject winText1;
    public GameObject winText2;

    public void player1scored()
    {
        player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        if (player1Score < 2)
        {
            resetPostition();
        }
        else
        {
            playButton.SetActive(true);
            quitButton.SetActive(true);
            winText1.SetActive(true);
            player1Score -= player1Score;
            Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
            player2Score -= player2Score;
            Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        }
    }

    public void player2scored()
    {
        player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        if (player2Score < 2)
        {
            resetPostition();
        }
        else
        {
            playButton.SetActive(true);
            quitButton.SetActive(true);
            winText2.SetActive(true);
            player1Score -= player1Score;
            Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
            player2Score -= player2Score;
            Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        }
    }

    private void resetPostition()
    {
        ball.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();
    }
}
