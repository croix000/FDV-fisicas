using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpforce;
    Rigidbody2D rigidbody2D;
    Vector2 movement;
    [SerializeField] float speed = 2f;
    SpriteRenderer spriteRenderer;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float horizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float vertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(horizontal, vertical);

        transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;

        if (Input.GetKeyDown("space") && Mathf.Abs(rigidbody2D.velocity.y)<0.001f)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

        if (horizontal > 0)
        {
            spriteRenderer.flipX = true;
            animator.SetFloat("speed", 1);
        }
        else if (horizontal < 0)
        {

            spriteRenderer.flipX = false;

            animator.SetFloat("speed", 1);
        }
        else if (horizontal == 0) {

            animator.SetFloat("speed", 0);
        }

        if (Mathf.Abs(rigidbody2D.velocity.y) < 0.001f)
            animator.SetBool("grounded", true);
        else
            animator.SetBool("grounded", false);


        if (Input.GetKeyDown("x"))
        {
            GameObject.FindGameObjectWithTag("NPC").GetComponent<NPCController>().explode();
        }
    }

}
