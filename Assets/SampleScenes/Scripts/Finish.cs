using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private Text finishText;
    // Start is called before the first frame update
    
    public void Finishing()
    {
        finishText.text = "Finish";
    }
}
