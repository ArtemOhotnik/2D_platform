using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Control : MonoBehaviour
{
    public float speed;
    public float jumpForse;
    private float moveInput;
    public Joystick joystik;

    private Rigidbody2D rb;


    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatISGround;
    public float Coin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        moveInput = joystik.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }

    private void Update()

    {

        float verticalMove = joystik.Vertical;
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatISGround);
        if (isGrounded == true && verticalMove >= .5f)
        {
            rb.velocity = Vector2.up * jumpForse;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Coin += 1;
        }

        if (this.CompareTag("Player") && other.CompareTag("End"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}


