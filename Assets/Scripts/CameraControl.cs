using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControl : MonoBehaviour
{
    public ChangeObject changeCamera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            changeCamera.ChangeObjects();
    }

}
