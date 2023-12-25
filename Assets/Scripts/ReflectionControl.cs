using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionControl : MonoBehaviour
{
    public ChangeObject changeReflection;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            changeReflection.ChangeObjects();
    }
}
