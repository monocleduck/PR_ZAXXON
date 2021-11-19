using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void HighScores()
    {
        SceneManager.LoadScene(3);
    }


    public void Options()
    {
        SceneManager.LoadScene(4);
    }

    public void Quit()
    {
        SceneManager.LoadScene(5);
    }
}
