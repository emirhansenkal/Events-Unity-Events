using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTest : MonoBehaviour
{
    [Serializable] public class OnClicked : UnityEvent{ }
    [Serializable] public class OnPrint : UnityEvent<int>{ }

    public OnClicked onLeftClicked;
    public OnClicked onRightClicked;

    public OnPrint onPrint;
    
    private void Start()
    {
        onRightClicked.AddListener(PrintRight);
        onPrint.AddListener(PrintValue);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onLeftClicked.Invoke();
        }
        else if(Input.GetMouseButtonDown(1))
        {
            onRightClicked.Invoke();
            onPrint.Invoke(13);
        }
    }

    public void PrintValue(int value)
    {
        Debug.Log(value);
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
