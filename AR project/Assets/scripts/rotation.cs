using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private float zAcc;
    //private GameObject invisibleCube;
    // Start is called before the first frame update
    void Start()
    {
        zAcc = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, Time.deltaTime* zAcc);
        //zAngle += 1;
    }
}
