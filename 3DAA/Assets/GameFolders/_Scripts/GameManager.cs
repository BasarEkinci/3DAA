using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] GameObject stick;
    [SerializeField] Transform stickSpawnPos;
    
    public bool IsGameOver { get;  set; }
    public int Score { get; set; }
    public int HighScore { get; private set; }
    
    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
    private void Start()
    {
        SpawnKnife();
        Score = 0;
        IsGameOver = false;
    }
    private void Update()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore",HighScore);
            PlayerPrefs.Save();
        }
        HighScore = PlayerPrefs.GetInt("HighScore");
    }
    public void SpawnKnife()
    {
        Instantiate(stick, stickSpawnPos.position, stickSpawnPos.transform.rotation);
    }

    public void RestartGame()
    {
        IsGameOver = false;
        SceneManager.LoadScene(0);
        Score = 0;
    }
    
}
