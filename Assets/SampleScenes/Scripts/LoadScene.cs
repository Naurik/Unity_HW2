using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScenes(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
