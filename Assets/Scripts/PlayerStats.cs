using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealthText;
    private int playerHealthNum = 2;
    [SerializeField] private GameObject gameOverScreen;
    private int scoreNum;
    [SerializeField] private TextMeshProUGUI scoreText;


    void Update()
    {
        playerHealthText.text = playerHealthNum.ToString();
        scoreText.text = scoreNum.ToString();
        //Debug.Log(playerHealthNum);
        
        if (playerHealthNum <= 0)
        {
            gameOverScreen.SetActive(true);
        }
        
    }

    public int DecrementHealthOnHit()
    {
        return playerHealthNum--;
    }
    public int GetPlayerHealth()
    {
        return playerHealthNum;
    }
    public int IncrementScore()
    {
        return scoreNum += 10;
    }
}
