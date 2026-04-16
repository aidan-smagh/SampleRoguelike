using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealthText;
    [SerializeField] private int playerHealthNum = 2;

    void Update()
    {
        playerHealthText.text = playerHealthNum.ToString();
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
