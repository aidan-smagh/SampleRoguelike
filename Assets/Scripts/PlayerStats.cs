using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealthText;
    [SerializeField] private int playerHealthNum = 2;
    [SerializeField] private GameObject gameOverScreen;

    void Update()
    {
        playerHealthText.text = playerHealthNum.ToString();
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

}
