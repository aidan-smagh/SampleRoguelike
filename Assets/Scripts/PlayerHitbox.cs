using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("contact");
            //other.GetComponent<EnemyStats>()?.TakeDamage(damage);
        }
    }
}
