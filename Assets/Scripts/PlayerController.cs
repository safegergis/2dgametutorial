using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public InputAction MoveAction;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();

        //uses Time.deltaTime to make character consistently move 0.1f
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
    }
}
