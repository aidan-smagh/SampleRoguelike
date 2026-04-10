using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Collider hookHitboxCollider;
    [SerializeField] private GameObject hookHitboxGO;
    void Start()
    {
        //hookhitbox.enabled = false;
    }
    public void EnableHookHitbox()
    {
        //Debug.Log("hook hitbox enabled");
        hookHitboxGO.SetActive(true);
        hookHitboxCollider.enabled = true;
    }
    public void DisableHookHitbox()
    {
        //Debug.Log("hook hitbox disabled");
        hookHitboxGO.SetActive(false);
        hookHitboxCollider.enabled = false;
        
    }
}
