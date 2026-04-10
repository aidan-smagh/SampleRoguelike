using UnityEngine;

public class EnemyRagdollKnockback : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    public void Knockback(GameObject enemy)
    {
        Rigidbody[] rb = enemy.GetComponentsInChildren<Rigidbody>();
        ForceMode mode = ForceMode.Impulse;
        CharacterController controller = enemy.GetComponent<CharacterController>();
        controller.enabled = !controller.enabled;
        foreach (Rigidbody bodypart in rb)
        {
            bodypart.isKinematic = false;
            bodypart.useGravity = false;
            //bodypart.GetComponent<BoxCollider>().enabled = !bodypart.GetComponent<BoxCollider>().enabled;
            bodypart.AddForce(Vector3.forward * 50, mode);
            bodypart.useGravity = true;
        }
            
    }
}
