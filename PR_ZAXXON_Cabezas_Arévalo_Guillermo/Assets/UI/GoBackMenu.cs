using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBackMenu : MonoBehaviour
{
    float HScore = 0;

    public Text HScoreText;

    public void Update()
    {
        ScoreComparator();

        HScoreText.text = "" + HScore;

    }



    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }


    void ScoreComparator()
    {
        if(HScore< LIVES.Score)
        {
            HScore = LIVES.Score;
        }
    }


}
