using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rptatepbjact : MonoBehaviour
{
    // Start is called before the first frame update

    public int rotatespeed = 7;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
}
