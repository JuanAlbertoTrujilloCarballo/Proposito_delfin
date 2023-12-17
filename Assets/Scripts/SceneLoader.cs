using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void DoLoadScene(string sceneName)
    {
        Debug.Log(sceneName);
        SceneManager.LoadScene(sceneName);
        
    }
}
