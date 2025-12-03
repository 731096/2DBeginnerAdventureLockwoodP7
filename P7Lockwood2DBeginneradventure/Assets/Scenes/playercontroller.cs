using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    int currentHealth;

    public float speed = 3.0f;


    public int maxHealth = 5;
    int currenthealth;
    
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move); 
    }


    private void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    void ChangeHealth (int amount) 
    {
        currenthealth = Mathf.Clamp(currenthealth + amount, 0, maxHealth);
        Debug.Log(currenthealth + "/" + maxHealth);
    
    }



}
