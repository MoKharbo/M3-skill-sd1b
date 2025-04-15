using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;
    void Update()
    {
        Bin2Dec();
    }

    private void Bin2Dec()
    {
        value = 0;
        if (bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state) { value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }
    }

    public void SetValue(int newValue)
    {
        if (newValue >= 128)
        {
            newValue -= 128;
            bits[7].state = true;
        }
        else
        {
            bits[7].state = false;
        }
        if (newValue >= 64)
        {
            newValue -= 64;
            bits[6].state = true;
        }
        else
        {
            bits[6].state = false;
        }
        if (newValue >= 32)
        {
            newValue -= 32;
            bits[5].state = true;
        }
        else 
        {
            bits[5].state = false;
        }
        if  (newValue >= 16)
        {
            newValue -= 16;
            bits[4].state = true;
        }
        else
        {
            bits[4].state = false;
        }
        if  (newValue >= 8)
        {
            newValue -= 8;
            bits[3].state = true;
        }
        else
        {
            bits[3].state = false;
        }
        if (newValue >= 4)
        {
            newValue -= 4;
            bits[2].state = true;
        }
        else
        { 
            bits[2].state = false;
        }
        if (newValue >= 2)
        {
            newValue -= 2;
            bits[1].state = true;
        }
        else
        { 
            bits[1].state = false;
        }
        if  (newValue >= 1)
        {
            newValue -= 1;
            bits[0].state = true;
        }
        else
        {
            bits[0].state = false;
        }
        this.value = newValue;
    }

    public string getHex()
    {
        string HexValue = value.ToString("X2");
        return HexValue;
    }
}
