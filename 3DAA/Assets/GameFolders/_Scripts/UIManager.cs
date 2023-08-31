using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text startText;
    [SerializeField] TMP_Text highScoreText;
    [SerializeField] GameObject resartButton;
    private void Update()
    {

        scoreText.text ="Score\n" + GameManager.Instance.Score;
        highScoreText.text = "High Score\n" + GameManager.Instance.HighScore;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(startText.gameObject.activeSelf)
                startText.gameObject.SetActive(false);   
        }

        if (GameManager.Instance.IsGameOver)
        {
            resartButton.SetActive(true);
        }
    }

    public void RestartButton()
    {
        GameManager.Instance.RestartGame();
        resartButton.SetActive(false);
    }
}
