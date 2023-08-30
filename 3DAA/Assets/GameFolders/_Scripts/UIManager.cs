using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text startText;
    
    [SerializeField] GameObject gamePanel;
    

    private void Update()
    {
        scoreText.text ="Score\n" + GameManager.Instance.Score;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(startText.gameObject.activeSelf)
                startText.gameObject.SetActive(false);   
        }
    }
}
