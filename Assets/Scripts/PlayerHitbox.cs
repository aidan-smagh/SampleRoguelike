using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    private Animator animator;
    private GameObject enemy;
    void OnTriggerEnter(Collider other)
    {
        //do nothing if two colliders in the same gameobject collide
        if (other.transform.root == transform.root)
            return;

        if (other.CompareTag("EnemyHurtbox"))
        {
            enemy = other.transform.parent.gameObject;
            animator = enemy.GetComponent<Animator>();
            animator.enabled = false;
            EnemyRagdollKnockback knockback = enemy.GetComponent<EnemyRagdollKnockback>();
            knockback.Knockback(enemy);
        } 
        else if (other.CompareTag("PlayerHurtbox"))
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
