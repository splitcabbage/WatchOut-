
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioClip saw;


    public void Start()
    {
        GetComponent<AudioSource>().clip = saw;
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().EndGame();
        }

       
    }

}
