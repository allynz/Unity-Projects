using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanger : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject LevelCompleteUI;

    public void completelevel()
    {
        LevelCompleteUI.SetActive(true);
    }

    public void endGame()
    {
        
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restartGame", restartDelay);

        }
        

    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
