using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    private Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("contact");

            //take the gameObject the collider is connected to (Banana Man)
            //then get the animator component attached to the gameObject
            animator = other.gameObject.GetComponent<Animator>();
            animator.enabled = false;
            EnemyRagdollKnockback knockback = other.GetComponent<EnemyRagdollKnockback>();
            knockback.Knockback(other.gameObject);
        }
    }
}
