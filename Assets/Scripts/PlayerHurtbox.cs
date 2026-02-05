using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    private PlayerStats playerstats;

    void Awake()
    {
        PlayerStats stats = GetComponentInParent<PlayerStats>();
    }
    public void TakeHit()
    {
        //stats.TakeDamage(damage);
    }
}
