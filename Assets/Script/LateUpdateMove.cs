using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    private float speed = 2.0f;

    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}