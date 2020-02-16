using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    Rigidbody rigidbody;
    [SerializeField]
    private float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rigidbody.AddForce(((transform.right * horizontal) + (transform.forward * vertical)) * speed / Time.deltaTime);
    }
}
