using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Vector2 direction;
    [SerializeField] private float speed;

    private void Start()
    {
        rigidBody = GetComponentInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX;
        float dirY;

        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        direction.Set(dirX, dirY);
        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = direction * speed;
    }


}
