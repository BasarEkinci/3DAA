using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject gamePanel;

    private void Update()
    {
        scoreText.text = GameManager.Instance.Score.ToString();
    }
}
