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
    public int GameCount;

    private string gameCount = "Game Count";
    private string highScore = "High Score";
    
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
        SetHighScore();
    }

    private void SetHighScore()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt(highScore,HighScore);
            PlayerPrefs.Save();
        }
        HighScore = PlayerPrefs.GetInt(highScore);
        GameCount = PlayerPrefs.GetInt(gameCount);
    }
    
    public void SpawnKnife()
    {
        Instantiate(stick, stickSpawnPos.position, stickSpawnPos.transform.rotation);
    }

    public void RestartGame()
    {
        IsGameOver = false;
        GameCount++;
        PlayerPrefs.SetInt(gameCount,GameCount);
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);
        Score = 0;
    }
    
}
