using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    [SerializeField]
    private Finish finishText;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            finishText.Finishing();
            SceneManager.LoadScene(0);
        }
    }

}
