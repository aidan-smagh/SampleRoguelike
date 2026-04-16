using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    private Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root == transform.root)
            return;
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("player hitbox contact");

            //take the gameObject the collider is connected to (Banana Man)
            //then get the animator component attached to the gameObject
            animator = other.gameObject.GetComponent<Animator>();
            animator.enabled = false;
            EnemyRagdollKnockback knockback = other.GetComponent<EnemyRagdollKnockback>();
            knockback.Knockback(other.gameObject);
        } 
        else if (other.CompareTag("PlayerHurtbox"))
        {
            Debug.Log("enemy hitbox contact");
            //Debug.Log("Hit object: " + other.name);
            PlayerStats playerHealth = other.GetComponentInParent<PlayerStats>();
            Debug.Log(playerHealth);
            playerHealth.DecrementHealthOnHit();
            Debug.Log(playerHealth.GetPlayerHealth());
        }
    }
}
