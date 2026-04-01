using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    public CharacterController controller;
    [SerializeField] private float speed = 3;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity; 
    public Transform cam;

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

        Vector3 dir = new Vector3(h, 0f, v).normalized;

        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            //RunForward
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            bool isRunning = Keyboard.current.wKey.isPressed;
            playerAnim.SetBool("RunForward", isRunning);
            controller.Move(moveDirection.normalized * speed * Time.deltaTime); 
        }



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
    }
}
