using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Main : MonoBehaviour
{
    [SerializeField]
    private RigidbodyFirstPersonController player;
    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    { 
    }
}
