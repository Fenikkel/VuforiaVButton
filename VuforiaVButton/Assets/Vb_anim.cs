﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator cubeAni;

    // Use this for initialization
    void Start () {
        vbBtnObj = GameObject.Find("LacieBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        cubeAni.Play("cube_animation"); Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
}
