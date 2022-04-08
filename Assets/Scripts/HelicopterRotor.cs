using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterRotor : MonoBehaviour
{
    private float rotorSpeed = 3000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotorSpeed * Time.deltaTime);
    }
}
