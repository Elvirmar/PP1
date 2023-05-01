using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatAndMoveBackground : MonoBehaviour
{
    private Vector3 startPos;
    public float speed = 10.0f;
    private Rigidbody objectRb;
    public float bottomBoundary = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        objectRb.transform.Translate(Vector3.forward * -speed *Time.deltaTime);

        if (transform.position.z < startPos.z -bottomBoundary)
        {
            transform.position = startPos;
        }
    }
}
