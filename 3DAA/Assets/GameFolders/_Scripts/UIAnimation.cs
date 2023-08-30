using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] TMP_Text startText;

    private void Start()
    {
        startText.transform.DOScale(Vector3.one * 1.1f, 0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
