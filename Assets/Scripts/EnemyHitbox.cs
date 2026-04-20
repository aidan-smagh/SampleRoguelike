using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    private Animator animator;
    private GameObject enemy;
    void OnTriggerEnter(Collider other)
    {
        //do nothing if two colliders in the same gameobject collide
        if (other.transform.root == transform.root)
            return;

        if (other.CompareTag("PlayerHurtbox"))
        {
            //Debug.Log("enemy hitbox contact");
            //Debug.Log("Hit object: " + other.name);
            PlayerStats playerHealth = other.GetComponentInParent<PlayerStats>();
            //Debug.Log(playerHealth);
            playerHealth.DecrementHealthOnHit();
            //Debug.Log(playerHealth.GetPlayerHealth());
        }
    }
}