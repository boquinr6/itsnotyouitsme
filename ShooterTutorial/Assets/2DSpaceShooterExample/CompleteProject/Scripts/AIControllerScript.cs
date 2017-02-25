//using UnityEngine; 
//using System.Collections;
//
//public class AIControllerScript : MonoBehaviour { 
//
////    // start at 10f or 10 float
////    public float maxSpeed = 10f;
////	public LayerMask whatIsGround;
////	float speed;
////
////    Animator anim; 
//// 
////    bool grounded = false;
////
////    // not sure what this is
////    public Transform groundCheck;
////    float groundRadius = 0.2f;
////    public float jumpForce = 700f;
//// 
////    // Use this for initialization
////    void Start () 
////    {
////        anim = GetComponent<Animator> ();
//////		speed = Random.Range (1f, 5f);
////    }
//// 
////    // Update is called once per frame
////    void FixedUpdate ()
////    {
////        grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
////        anim.SetBool ("Ground", grounded);
////     
////        anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D> ().velocity.y);
////
////        float move = 1.0f;
////      
////        anim.SetFloat ("Speed", Mathf.Abs (move));
////
////        //Get the physical object
////        GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
////     
////     //float move = Input.GetAxis ("Horizontal");
////     
////     //anim.SetFloat ("Speed", Mathf.Abs (move));
////     
////     //GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
////     
////    }
//// 
////    void Update()
////    {
////
//////		Vector2 position = transform.position;
//////
//////		position = new Vector2 (position.x + speed * Time.deltaTime, position.y);
//////
//////		transform.position = position;
//////
//////		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
//////
//////		if (transform.position.x > max.x) {
//////			Destroy (gameObject);
//////		}
////
////        if (grounded && Input.GetKeyDown (KeyCode.Space)) 
////        {
////            anim.SetBool("Ground", false);
////            GetComponent<Rigidbody2D> ().AddForce(new Vector2(0, jumpForce));
////        }
////    }
//// 
//
//	// Public variable that contains the speed of the enemy
//	public float speed;
//	private Rigidbody2D rb2d;
//
//	// Function called when the enemy is created
//	void Start () {
//		// Get the rigidbody component
//		rb2d = GetComponent<Rigidbody2D> ();
//
//		// Add a vertical speed to the enemy
//		rb2d.velocity.y = speed;
//
//		// Make the enemy rotate on itself
//		rb2d.angularVelocity = Random.Range(-200, 200);
//	}
//
//	// Function called when the object goes out of the screen
//	void OnBecameInvisible() {
//		// Destroy the enemy
//		Destroy(gameObject);
//	}
//}
//
