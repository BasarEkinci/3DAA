using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;


    private void Update()
    {
        scoreText.text = GameManager.Instance.Score.ToString();
    }
}
