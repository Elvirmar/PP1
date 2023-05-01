using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody objectRb;
    private float bottomBoundary = -15.0f;
        

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();  

    }

    // Update is called once per frame
    void Update()
    {
        objectRb.transform.Translate(Vector3.forward * -speed * Time.deltaTime);

        if (transform.position.z < bottomBoundary)
        {
            Destroy(gameObject);
        }
    }
}
