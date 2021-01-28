using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void OnClicked();

    public static event OnClicked onLeftClicked;
    public static event OnClicked onRightClicked;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(onLeftClicked != null)
                onLeftClicked();
        }else if (Input.GetMouseButtonDown(1))
        {
            if(onRightClicked != null)
                onRightClicked();
        }
    }

    public void PrintRight()
    {
        Debug.Log("Right");
    }
    
    public void PrintLeft()
    {
        Debug.Log("Left");
    }
}
