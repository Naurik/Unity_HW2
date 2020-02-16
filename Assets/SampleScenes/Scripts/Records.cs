using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Records : MonoBehaviour
{
    [SerializeField]
    private Text textRec;

    // Start is called before the first frame update
    public void RecordUpdate(int coinRecord)
    {
        textRec.text =  coinRecord.ToString();
    }
}
