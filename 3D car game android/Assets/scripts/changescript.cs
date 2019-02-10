using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescript : MonoBehaviour
{
    
    public void changescene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void quitgame()
    {
        Application.Quit();
    }

}
