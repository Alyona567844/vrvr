using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText; 

    private void Update()
    {
        scoreText.text = "Ñ÷¸ò: " + ScoreManager.Instance.score;
    }
}