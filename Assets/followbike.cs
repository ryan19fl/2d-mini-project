using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followbike : MonoBehaviour
{
    Transform bike;
    // Start is called before the first frame update
    void Start()
    {
        bike = GameObject.Find("body").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<bike.position.x+1)
        {
            transform.Translate(.6f, 0, 0);
        }
    }
}
