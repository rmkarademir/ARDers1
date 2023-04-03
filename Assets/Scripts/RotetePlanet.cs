using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotetePlanet : MonoBehaviour
{
    public GameObject sun;
    public float speed = 1f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.RotateAround(sun.transform.position, sun.transform.up,speed * Time.deltaTime);
    }
}
