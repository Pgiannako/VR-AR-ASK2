using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationY : MonoBehaviour
{
    private float yAcc;
    //private GameObject invisibleCube;
    // Start is called before the first frame update
    void Start()
    {
        yAcc = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, Time.deltaTime* yAcc, 0f);
        //zAngle += 1;
    }
}
