using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitgame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadNextLevel();
        }
    }

    private void loadNextLevel()
    {
        Application.Quit();
    }
}
