using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int myValue;

    void Update()
    {
        myByte.SetValue(myValue);
    }

    public void SetValue(int myValue)
    {
       
    }
}