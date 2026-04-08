using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    private Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("contact");
            animator = other.gameObject.GetComponent<Animator>();
            animator.enabled = false;
        }
    }
}
