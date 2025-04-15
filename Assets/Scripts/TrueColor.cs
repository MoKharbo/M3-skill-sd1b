using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueColor : MonoBehaviour
{
    [SerializeField] Pixel pixel;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float column = Random.Range(-4f, 4f);
            float row = Random.Range(-4f, -4f);
            Pixel CopyVanPixel = Instantiate(pixel, new Vector3(column, row, 0), Quaternion.identity);
            CopyVanPixel.color = setRandomColor();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Color setRandomColor()
    {
        float Red = Random.value;
        float Green = Random.value;
        float Blue = Random.value;

        return new Color(Red, Green, Blue);
    }
}
