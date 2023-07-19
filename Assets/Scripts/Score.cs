using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public TextMeshProUGUI scoreText;
    private int totalScore;

    public int scoreMultiplier;

    private void FixedUpdate()
    {
        if(PlayerManager.isGameStarted == true)
        {
            totalScore += scoreMultiplier;
            scoreText.text = totalScore.ToString();
        }
    }
}
