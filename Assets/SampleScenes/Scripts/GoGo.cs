using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGo : MonoBehaviour
{
    [SerializeField]
    private Transform coin;

    [SerializeField]
    private float step = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == coin.position)
            step += 10;

        transform.position = Vector3.MoveTowards(transform.position, coin.position, step + Time.deltaTime);
    }
}
