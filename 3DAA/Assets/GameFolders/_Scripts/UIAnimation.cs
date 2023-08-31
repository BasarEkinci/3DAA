using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] TMP_Text startText;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;

    private void Start()
    {
        startText.transform.DOScale(Vector3.one * 1.1f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !GameManager.Instance.IsGameOver)
        {
            scoreText.transform.DOScale(Vector3.one * 1.1f, 0.2f).SetEase(Ease.Linear).From();
        }

        if (GameManager.Instance.IsGameOver)
        {
            scoreText.transform.DOMoveY(750, 1f);
            highScoreText.transform.DOScale(1f, 0.2f);
        }
        
    }
}
