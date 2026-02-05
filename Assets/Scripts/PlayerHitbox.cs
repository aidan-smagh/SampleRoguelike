using UnityEngine;

public class PlayerHitbox
{
    [SerializeField] private int damage = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("contact");
            //other.GetComponent<EnemyStats>()?.TakeDamage(damage);
        }
    }
}
