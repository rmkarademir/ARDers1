using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    Vector3 donme;
    public int x1, y1, z1;

    // Start is called before the first frame update



    void Start()
    {
        donme = new Vector3(x1, y1, z1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(donme * Time.deltaTime);


    }
}
