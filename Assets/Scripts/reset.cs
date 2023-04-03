using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider deneme)
    {
        if (deneme.gameObject.CompareTag("wall"))
        {
            transform.localPosition = originalPos;
            Debug.Log("Dikkat, " + deneme.gameObject.name + " nesnesi bana çarptı!");

        }



    }
}

