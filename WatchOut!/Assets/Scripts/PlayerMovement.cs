
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
   
    public float forwardForce = 1000f;
    public float sideWays = 1000f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
      
        if (Input.GetKey("d")) {
            rb.AddForce(sideWays * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(- sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
