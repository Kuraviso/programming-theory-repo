using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{

    private float speed = 25f;
    private Vector3 startPos;
    private float loopHeight = -297;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.z < loopHeight)
        {

            transform.position = startPos; //268
        }
    }
}
