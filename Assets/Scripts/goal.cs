using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal == false)
            {
                Debug.Log("Player 1 Scored!");
                GameObject.Find("GameManager").GetComponent<gameManager>().player1scored();
            }
            else
            {
                Debug.Log("Player 2 Scored!");
                GameObject.Find("GameManager").GetComponent<gameManager>().player2scored();
            }
        }
    }
}
