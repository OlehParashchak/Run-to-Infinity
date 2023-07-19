using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Start()
    {
        int recordScore = PlayerPrefs.GetInt("recordScore");
        scoreText.text = recordScore.ToString();
    }
}
