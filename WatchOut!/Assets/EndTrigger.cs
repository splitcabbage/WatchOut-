
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public AudioClip saw2;
    public GameManager gameManager;
    public void Start()
    {
        GetComponent<AudioSource>().clip = saw2 ;
    }

    public void OnTriggerEnter()
    {
        GetComponent<AudioSource>().Play();
        gameManager.CompleteLevel();
    }
}
