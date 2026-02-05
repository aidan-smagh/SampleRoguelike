using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    [SerializeField] private float speed = 1;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float turnSpeed = 10f;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {

        float h = 0f;
        float v = 0f;

        if (Keyboard.current.aKey.isPressed) h = -1f;
        if (Keyboard.current.dKey.isPressed) h = 1f;
        if (Keyboard.current.wKey.isPressed) v = 1f;
        if (Keyboard.current.sKey.isPressed) v = -1f;

        Vector3 dir = new Vector3(h, 0f, v);

        if (dir.magnitude > 1f) dir.Normalize();

        //RunForward
        bool isRunning = Keyboard.current.wKey.isPressed;
        playerAnim.SetBool("RunForward", isRunning);
        transform.Translate(dir * speed * Time.deltaTime, Space.World);

        //drink
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            playerAnim.SetTrigger("Drink");
        }

        //hook
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            //enable the hitbox
            playerAnim.SetTrigger("Hook");
            //turn it back off
        }

        if (Camera.main != null)
        {
            cameraTransform = Camera.main.transform;
        }
        else
        {
            Debug.Log("No main camera found");
        }

        if (cameraTransform == null) return;
        Vector3 camForward = cameraTransform.forward;
        camForward.y = 0f;

        if (camForward.sqrMagnitude> 0.001f)
        {
            Quaternion target = Quaternion.LookRotation(camForward);
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                target,
                turnSpeed = Time.deltaTime
            );
        }
    }
}
