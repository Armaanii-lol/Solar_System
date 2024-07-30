using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform target; 
    public int speed;
    void Start()
    {

    }
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed*Time.deltaTime);
    }
}
