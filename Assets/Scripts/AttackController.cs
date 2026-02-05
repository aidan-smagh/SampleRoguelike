using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Collider hookhitbox;
    void Start()
    {
        hookhitbox.enabled = false;
    }
    public void EnableHookHitbox()
    {
        hookhitbox.enabled = true;
    }
    public void DisableHookHitbox()
    {
        hookhitbox.enabled = false;
    }
}
