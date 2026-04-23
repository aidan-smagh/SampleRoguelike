using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    private Animator animator;
    private GameObject enemy;
    private PlayerStats playerStats;
    //fires every time two colliders that are set as triggers hit
    void OnTriggerEnter(Collider other)
    {
        //do nothing if two colliders in the same gameobject collide
        if (other.transform.root == transform.root)
            return;

        if (other.CompareTag("EnemyHurtbox"))
        {
            playerStats = gameObject.GetComponentInParent<PlayerStats>();
            Debug.Log(playerStats);
            playerStats.IncrementScore();
            Debug.Log("Hit object: " + other.name);
            enemy = other.transform.parent.gameObject;
            animator = enemy.GetComponent<Animator>();
            animator.enabled = false;
            EnemyRagdollKnockback knockback = enemy.GetComponent<EnemyRagdollKnockback>();
            knockback.Knockback(enemy);
        } 
    }
}
