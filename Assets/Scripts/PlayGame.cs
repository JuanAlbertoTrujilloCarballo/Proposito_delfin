using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Return)) SCManager.instance.LoadScene("Game");

    //}

    public void playGame()
    {
        SCManager.instance.LoadScene("Game");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
