using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    public InputAction Leftaction;
    public InputAction MoveACtion;

    // Start is called before the first frame update
    void Start()
    {
       // QualitySettings.vSyncCount = 0;
       // Application.targetFrameRate = 10;
        Leftaction.Enable();
        MoveACtion.Enable();
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 move = MoveACtion.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;
   

    }
}
