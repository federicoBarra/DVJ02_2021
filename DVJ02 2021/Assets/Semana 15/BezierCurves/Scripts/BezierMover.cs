using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class BezierMover : MonoBehaviour
{
    public BezierCurve bezierCurve;
    public bool moving;
    public bool loop;

    [Header("Object moved by speed")]
    public bool UseSpeed;
    public float Speed = 50;
    public float MaxSpeed = 50;
    public float MinSpeed = 50;
    public float Acceleration = 0;
    public bool RotateTowardsCurve = true;
    [Range(1,100)]
    public int RotationIndexOffset = 10;
    int posIndex;
    List<float> curveTimePoints;


    [Header("Object moved by total time on curve")]
    public bool UseTime;
    public float TotalTime = 0;
    public float TimeDistanceToLookAt = 0.5f;

    float t;
	// Use this for initialization
    protected virtual void Start() 
    {
	    curveTimePoints = bezierCurve.GetParametrizedTimePoints();
	}
	
	// Update is called once per frame
    protected virtual void Update()
	{
	    if (!moving)
	        return;

	    if (UseSpeed)
	        MoveBySpeed();
        else if (UseTime)
	        MoveByTime();
	}

    void MoveByTime()
    {
        t += Time.deltaTime;
        Vector3 position = bezierCurve.GetPointAt(t / TotalTime);

        transform.position = position;

        transform.right = transform.position - bezierCurve.GetPointAt((t + TimeDistanceToLookAt) / TotalTime);

        if (t >= TotalTime)
            Ended();
    }

    void MoveBySpeed()
    {
        float tPos = GetT2(ref posIndex, ref t);
        transform.position = bezierCurve.GetPointAt(tPos);

        float tRot;
        if (posIndex + RotationIndexOffset < curveTimePoints.Count)
            tRot = curveTimePoints[posIndex + RotationIndexOffset];
        else
            tRot = curveTimePoints[posIndex];

        transform.right = transform.position - bezierCurve.GetPointAt(tRot);

        Speed += Acceleration * Time.deltaTime;
        t += Time.deltaTime * Speed;

        if (posIndex + 2 >= curveTimePoints.Count && t >= 1)
        {
            Ended();
        }
    }

    float GetT2(ref int index, ref float tRemains)
    {
        float retTime = 0;
        int baseIndex = index;
        int nextIndex = index + 1;

        float t01 = curveTimePoints[baseIndex];
        float t02;
        if (curveTimePoints.Count > nextIndex)
            t02 = curveTimePoints[nextIndex];
        else
            t02 = curveTimePoints[baseIndex];

        retTime = t01;

        while (tRemains >= 1 && curveTimePoints.Count > nextIndex+1)
        {
            retTime += t02 - t01;
            nextIndex++;
            t01 = t02;
            t02 = curveTimePoints[nextIndex];
            tRemains -= 1f;
        }

        retTime += (t02 - t01) * tRemains;
        index = nextIndex - 1;
        return retTime;
    }

    public void Move()
    {
        moving = true;
    }

    void Ended()
    {
         if (loop)
             Loop();
    }

    void Loop()
    {
        if (UseSpeed)
            posIndex = 0;
        else if (UseTime)
            t -= TotalTime;
        
    }

}

