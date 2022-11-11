using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float points = 0f;
    
    public void ApplyPoint(float amount)
    {
        points = points + amount;
    }
}
