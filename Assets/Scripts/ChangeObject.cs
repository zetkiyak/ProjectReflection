using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ChangeObject
{
    public GameObject[] objects;

    public void ChangeObjects()
    {
        if (objects[0].activeInHierarchy)
            ChangeStatus(0, 1);
        else
            ChangeStatus(1, 0);
    }

    public void ChangeStatus(int a, int b)
    {
        objects[a].SetActive(false); objects[b].SetActive(true);
    }

}
