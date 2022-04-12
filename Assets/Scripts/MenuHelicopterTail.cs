using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHelicopterTail : MonoBehaviour
{
    private float rotorSpeed = 800;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotorSpeed * Time.deltaTime);
    }
}