using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsGameOver { get; private set; }
    public bool IsGameStarted { get; private set; }
    
    
    [SerializeField] GameObject stick;
    [SerializeField] Transform stickSpawnPos;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SpawnKnife();
    }

    public void SpawnKnife()
    {
        Instantiate(stick, stickSpawnPos.position, Quaternion.identity);
    }

    public void GameOver()
    {
        IsGameOver = true;
    }

    public void RestartGame()
    {
        IsGameOver = false;
        IsGameStarted = false;
    }
}
