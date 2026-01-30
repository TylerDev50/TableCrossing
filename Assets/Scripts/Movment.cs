using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public Rigidbody2D BodyPlayer;

    private float horizontal;
    private float vertical;
    public float Speed = 350;

    public bool isTurn = false;
    public float turnSpeed;

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        horizontal = 0;
        vertical = 0;

        if (Input.GetKey(KeyCode.A)) horizontal = -1;
        if (Input.GetKey(KeyCode.D)) horizontal = 1;
        if (Input.GetKey(KeyCode.W)) vertical = 1;
        if (Input.GetKey(KeyCode.S)) vertical = -1;


        if (isTurn)
        {
            transform.Rotate(0, 0, turnSpeed);
            isTurn = false;
        }
        else
        {
            turnSpeed = 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            turnSpeed = 0.2f;
            isTurn = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            turnSpeed = -0.2f;
            isTurn = true;
        }
    }

    private void FixedUpdate()
    {

        movement = new Vector3(horizontal, vertical, 0).normalized;
        BodyPlayer.linearVelocity = new Vector3(movement.x * Speed, movement.y * Speed, movement.z * Speed) * Time.fixedDeltaTime;

    }
}