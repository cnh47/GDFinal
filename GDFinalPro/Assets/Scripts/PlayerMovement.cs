using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public static bool PlayerAlive = true;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
        Debug.Log("Player Dead");
        PlayerAlive = false;
        Application.LoadLevel("GameOver");
    }


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        var InputMos= Input.mousePosition;
        InputMos.z = 10;
        mousePos = cam.ScreenToWorldPoint(InputMos);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float  angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
