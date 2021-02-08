using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Text player1ScoreText, player2ScoreText;
    int player1Score = 0, player2Score = 0;
    public void UpdateScore(string name)
    {
        Debug.Log("Update Score For " + name);
        
        if (name == "Player2")
        {
            player1Score += 1;
            player1ScoreText.text = player1Score.ToString();
        }
        else if (name == "Player1")
        {
            player2Score += 1;
            player2ScoreText.text = player2Score.ToString();
        }
    }
}
