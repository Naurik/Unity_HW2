using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private Records records;
    [SerializeField]
    private int coinRecord;
    private void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Player")
        {
            coinRecord += 10;
            records.RecordUpdate(coinRecord);
            Destroy(gameObject);
        }
    }
}
