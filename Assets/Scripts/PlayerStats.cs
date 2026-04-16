using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealthText;
    [SerializeField] private int playerHealthNum = 2;

    void Start()
    {
        playerHealthText.text = playerHealthNum.ToString();
    }
}
