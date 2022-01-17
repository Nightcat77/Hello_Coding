using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    float distance;
    float width;
    float height;
    void Start()
    {
        GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리" + distance);
    }
    void GetDistance(float x1, float y1, float x2, float y2)
    {
        width = x2 - x1;
        height = y2 - y1;

        distance = Mathf.Sqrt(width * width + height * height);

    }
}
