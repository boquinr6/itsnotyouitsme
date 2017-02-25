using UnityEngine; 
using System.Collections;

public class AIControllerScript : MonoBehaviour { 

    // start at 10f or 10 float
    public float maxSpeed = 10f; 

    Animator anim; 
 
    bool grounded = false;

    // not sure what this is
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public float jumpForce = 700f;
 
    // Use this for initialization
    void Start () 
    {
        anim = GetComponent<Animator> ();
    }
 
    // Update is called once per frame
    void FixedUpdate ()
    {
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool ("Ground", grounded);
     
        anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D> ().velocity.y);

        float move = 1.0f;
      
        anim.SetFloat ("Speed", Mathf.Abs (move));

        //Get the physical object
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
     
     //float move = Input.GetAxis ("Horizontal");
     
     //anim.SetFloat ("Speed", Mathf.Abs (move));
     
     //GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
     
    }
 
    void Update()
    {
        if (grounded && Input.GetKeyDown (KeyCode.Space)) 
        {
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D> ().AddForce(new Vector2(0, jumpForce));
        }
    }
 
}