using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class followplayer : MonoBehaviour
{
    public GameObject Tplayer;
    public Transform Tfollowtarget;
    private CinemachineVirtualCamera vcam;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tplayer==null)
        {
            Tplayer = GameObject.FindWithTag("player");
            if(Tplayer!=null)
            {
                Tfollowtarget = Tplayer.transform;
                vcam.LookAt = Tfollowtarget;
                vcam.Follow = Tfollowtarget;
            }
        }
    }
}
