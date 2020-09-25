
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float timeDelay = 1f;
    public GameObject completeLevelUI;


    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("restart", timeDelay);
        }
        

    }
    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
