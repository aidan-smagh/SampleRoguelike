using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private GameObject player;
    private Transform playerTransform;

    [SerializeField] private int health = 2;
    [SerializeField] private bool invincible;
    [SerializeField] private int damage = 100;

    void Awake()
    {
        player = gameObject;
        playerTransform = transform;
    }

    public bool SetInvincible(bool status)
    {
        return (invincible = status);
    }
    public bool GetInvincible()
    {
        return invincible;
    }
    private int TakeDamage(int damage)
    {
        health = health - damage;
        if (health == 0)
        {
            //death function
            //return health;
        }
        //player take damage animation
        return health;
    }
}
