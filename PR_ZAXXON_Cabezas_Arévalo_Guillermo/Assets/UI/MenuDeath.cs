using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuDeath : MonoBehaviour
{
    void start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        if(LIVES.vidas < 0)
        {
            gameObject.SetActive(false);
        }


        if(LIVES.vidas == 0)
        {
            gameObject.SetActive(true);
        }
    }




    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
