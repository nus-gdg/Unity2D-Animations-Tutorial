using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerInput : MonoBehaviour
{
    public float runSpeed = 40f;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float value = Input.GetAxis("Horizontal");
        bool jump = Input.GetAxis("Jump") > 0;
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        controller.Move(value * Time.deltaTime * runSpeed, crouch, jump);

    }
}
