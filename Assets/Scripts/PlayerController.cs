using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Vector2 move;
    public InputAction MoveAction;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2D.position + move * 3.0f * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
}
