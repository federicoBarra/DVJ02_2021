using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveExample : MonoBehaviour
{
    public AnimationCurve curva;

    public float duration = 1;
    public float t = 0;

    public Transform pointA;
    public Transform pointB;

    public bool goingToA;

    void Update()
    {
        t += Time.deltaTime;
        float val = curva.Evaluate(t / duration); // 0 - 1
        if (goingToA)
            transform.position = Vector3.Lerp(pointB.position, pointA.position, val);
        else
            transform.position = Vector3.Lerp(pointA.position, pointB.position, val);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            t = 0;
            goingToA = !goingToA;
        }
    }
}
