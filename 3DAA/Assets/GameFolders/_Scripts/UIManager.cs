using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text startText;
    [SerializeField] TMP_Text highScoreText;
    [SerializeField] TMP_Text restartText;
    [SerializeField] TMP_Text gamesPlayedText;
    [SerializeField] GameObject creditButton;

    private void Start()
    {
        restartText.transform.DOScale(Vector3.one * 1.1f, 0.3f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void Update()
    {
        SetTexts();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(startText.gameObject.activeSelf)
                startText.gameObject.SetActive(false);   
        }

        if (GameManager.Instance.IsGameOver)
        {
            restartText.gameObject.SetActive(true);
            creditButton.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R) && GameManager.Instance.IsGameOver)
        {
            GameManager.Instance.RestartGame();
            restartText.gameObject.SetActive(false);
            creditButton.SetActive(false);
        }
    }
    
    private void SetTexts()
    {
        scoreText.text ="Score\n" + GameManager.Instance.Score;
        highScoreText.text = "High Score\n" + GameManager.Instance.HighScore;
        gamesPlayedText.text = "Games\nPlayed : " + GameManager.Instance.GameCount;
    }

    public void CreditButton()
    {
        Application.OpenURL("https://linktr.ee/basarekinci");
    }
}
