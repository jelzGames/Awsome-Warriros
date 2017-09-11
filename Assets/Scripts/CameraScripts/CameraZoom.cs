﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public float zoom_Sensivity = 15f;
    public float zoom_Speed = 20f;
    public float zoom_Min = 30f;
    public float zoom_Max = 70f;

    private float z;

    private Camera mainCamera;




	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
        // there is in the gui camera too.
        z = mainCamera.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
        z += Input.GetAxis("Mouse ScrollWheel") * zoom_Sensivity;
        z = Mathf.Clamp(z, zoom_Min, zoom_Max);


	}

    private void LateUpdate()
    {
        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, z, Time.deltaTime * zoom_Speed);
    }
}
