using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Collider hookhitbox;
    void Start()
    {
        //hookhitbox.enabled = false;
    }
    public void EnableHookHitbox()
    {
        Debug.Log("hook hitbox enabled");
        hookhitbox.enabled = true;
    }
    public void DisableHookHitbox()
    {
        Debug.Log("hook hitbox disabled");
        hookhitbox.enabled = false;
        
    }
}
