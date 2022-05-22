using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationX : MonoBehaviour
{
    private float xAcc;
    //private GameObject invisibleCube;
    // Start is called before the first frame update
    void Start()
    {
        xAcc = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * xAcc, 0f, 0f );
        //xAngle += 1;
    }
}
