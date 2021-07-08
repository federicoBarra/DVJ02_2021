using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FloorCurveCreator : MonoBehaviour
{
    //[Range(1,999999)]
    public int PartsCount = 1;
    public float Width = 0.5f;
    public float Height = 0.5f;
    
    public BezierCurve bezierCurve;

    public float minVal = 01;
    public float maxVal = 2;
    public AnimationCurve curve;

    public Renderer rend;
    public Color origColor;
    public float t;
    public float Totalt;

    public bool animating;
    public float AnimateT;
    public float AnimateSpeed = 1;

    public Mesh m;
    public Vector3[] vertices;
    public Color[] colors;
    public Vector2[] uv;
    public int[] triangles;


    public Vector3[] points;
    Vector3[] offsetX;

    private bool enableDraw;

    
	// Use this for initialization
	public void Start () 
    {
        m = GetComponent<MeshFilter>().sharedMesh;
        CreateLineMesh();
        origColor = Color.red; //rend.sharedMaterial.GetColor("_EmissionColor");
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
            CreateLineMesh();

        if (Input.GetKeyDown(KeyCode.Z))
            animating = !animating;

        if (animating)
            AnimateMesh();

	    UpdateEmission();
	}

    void AnimateMesh()
    {
        AnimateT += Time.deltaTime * AnimateSpeed;
        int partsPlusOne = PartsCount + 1;

        float separation = 1f / PartsCount;
        float separationSum = 0;

        

        separationSum = 0;
        for (int i = 0; i < partsPlusOne; i++)
        {
            uv[i * 2 + 0] = new Vector2(1, separationSum + AnimateT);
            uv[i * 2 + 1] = new Vector2(0, separationSum + AnimateT);
            separationSum += separation;
            if (separationSum > 1)
                separationSum = 1;
        }
        m.uv = uv;
    }

    void UpdateEmission()
    {
        t += Time.deltaTime;
        if (t > Totalt)
        {
            t -= Totalt;
        }
        float val = minVal + ((maxVal - minVal) * curve.Evaluate(t / Totalt));
        Color final = origColor * Mathf.LinearToGammaSpace(val);

        //rend.sharedMaterial.SetColor("_EmissionColor", final);
        //rend.UpdateGIMaterials();
        //DynamicGI.SetEmissive(rend, final);
    }

    public Gradient colorGrad;
    public float gradientMultiplier = 1;


    void CreateLineMesh()
    {
        if (PartsCount < 1)
            PartsCount = 1;

        int partsPlusOne = PartsCount + 1;

        vertices = new Vector3[partsPlusOne * 2];
        colors = new Color[partsPlusOne * 2];
        uv = new Vector2[partsPlusOne * 2];
        triangles = new int[(partsPlusOne - 1) * 2 * 3];

        if (GetComponent<MeshFilter>().sharedMesh == null)
            m = GetComponent<MeshFilter>().mesh;
        else
            m = GetComponent<MeshFilter>().sharedMesh;
        m.Clear();

        points = new Vector3[partsPlusOne];
        offsetX = new Vector3[partsPlusOne];

        float separation = 1f / PartsCount;
        float separationSum = 0;

        for (int i = 0; i < partsPlusOne; i++)
        {
            float val = (float) i / (float) partsPlusOne;

            points[i] = bezierCurve.GetPointAt(separationSum);
            points[i] += Vector3.up * Mathf.PerlinNoise(val, val) * gradientMultiplier;

            //Debug.Log(points[i].x + "|" + points[i].y + "|" + points[i].z);
            separationSum += separation;
            if (separationSum > 1)
                separationSum = 1;
        }

        for (int i = 0; i < partsPlusOne; i++)
        {
            //float percent = (float)i / cuts;
            //float offsetVal = creator.LineSize.Evaluate(percent);
            Vector3 v;
            if (points.Length > i + 1)
                v = points[i] - points[i + 1];
            else
                v = points[i - 1] - points[i];

            var newVector = Vector3.Cross(v, Vector3.up);
            newVector.Normalize();
            
            offsetX[i] = Width * newVector;
        }

        for (int i = 0; i < partsPlusOne; i++)
        {
            vertices[i * 2 + 0] = points[i] + offsetX[i];
            vertices[i * 2 + 1] = points[i] - offsetX[i];

            colors[i * 2 + 0] = colorGrad.Evaluate(Random.Range(0.0f, 1.0f));
            colors[i * 2 + 1] = colorGrad.Evaluate(Random.Range(0.0f, 1.0f));
        }

        separationSum = 0;
        for (int i = 0; i < partsPlusOne; i++)
        {
            uv[i * 2 + 0] = new Vector2(0.8f, separationSum);
            uv[i * 2 + 1] = new Vector2(0.2f, separationSum);
            separationSum += separation;
            if (separationSum > 1)
                separationSum = 1;
        }

        for (int i = 0; i < triangles.Length / 6; i++)
        {
            triangles[i * 6 + 0] = i * 2;
            triangles[i * 6 + 1] = i * 2 + 1;
            triangles[i * 6 + 2] = i * 2 + 2;

            triangles[i * 6 + 3] = i * 2 + 2;
            triangles[i * 6 + 4] = i * 2 + 1;
            triangles[i * 6 + 5] = i * 2 + 3;
        }

        m.vertices = vertices;
        m.colors = colors;
        m.uv = uv;
        m.triangles = triangles;
        m.RecalculateNormals();
        enableDraw = true;
    }

    void CreateLineComplexMesh()
    {
        if (PartsCount < 1)
            PartsCount = 1;

        int partsPlusOne = PartsCount + 1;

        vertices = new Vector3[partsPlusOne * 4];
        colors = new Color[partsPlusOne * 4];
        uv = new Vector2[partsPlusOne * 4];
        triangles = new int[(partsPlusOne - 1) * 8 * 3];

        if (GetComponent<MeshFilter>().sharedMesh == null)
            m = GetComponent<MeshFilter>().mesh;
        else
            m = GetComponent<MeshFilter>().sharedMesh;
        m.Clear();

        points = new Vector3[partsPlusOne];
        offsetX = new Vector3[partsPlusOne];

        float separation = 1f / PartsCount;
        float separationSum = 0;

        for (int i = 0; i < partsPlusOne; i++)
        {
            points[i] = bezierCurve.GetPointAt(separationSum);
            //Debug.Log(points[i].x + "|" + points[i].y + "|" + points[i].z);
            separationSum += separation;
            if (separationSum > 1)
                separationSum = 1;
        }

        for (int i = 0; i < partsPlusOne; i++)
        {
            //float percent = (float)i / cuts;
            //float offsetVal = creator.LineSize.Evaluate(percent);
            Vector3 v;
            if (points.Length > i + 1)
                v = points[i] - points[i + 1];
            else
                v = points[i - 1] - points[i];

            var newVector = Vector3.Cross(v, Vector3.up);
            newVector.Normalize();

            offsetX[i] = Width * newVector;
        }

        for (int i = 0; i < partsPlusOne; i++)
        {
            vertices[i * 2 + 0] = points[i] + offsetX[i];
            vertices[i * 2 + 1] = points[i] - offsetX[i];

            colors[i * 2 + 0] = Color.white;
            colors[i * 2 + 1] = Color.white;
        }

        separationSum = 0;
        for (int i = 0; i < partsPlusOne; i++)
        {
            uv[i * 2 + 0] = new Vector2(0.8f, separationSum);
            uv[i * 2 + 1] = new Vector2(0.2f, separationSum);
            separationSum += separation;
            if (separationSum > 1)
                separationSum = 1;
        }

        for (int i = 0; i < triangles.Length / 6; i++)
        {
            triangles[i * 6 + 0] = i * 2;
            triangles[i * 6 + 1] = i * 2 + 1;
            triangles[i * 6 + 2] = i * 2 + 2;

            triangles[i * 6 + 3] = i * 2 + 2;
            triangles[i * 6 + 4] = i * 2 + 1;
            triangles[i * 6 + 5] = i * 2 + 3;
        }

        m.vertices = vertices;
        m.colors = colors;
        m.uv = uv;
        m.triangles = triangles;
        m.RecalculateNormals();
        enableDraw = true;
    }

    void OnDrawGizmos()
    {
        //if (!enableDraw)
            return;

        Gizmos.color = Color.yellow;
        //Gizmos.DrawRay(transform.position, 1);

        int partsPlusOne = PartsCount + 1;


        for (int i = 0; i < partsPlusOne; i++)
        {
            //float percent = (float)i / cuts;
            //float offsetVal = creator.LineSize.Evaluate(percent);
            Vector3 v;
            if (points.Length > i + 1)
                v = points[i] - points[i + 1];
            else
                v = points[i - 1] - points[i];

            var newVector = Vector3.Cross(v, Vector3.up);
            newVector.Normalize();

            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(points[i], -v);
            //Gizmos.Draw
            Gizmos.color = Color.magenta;
            Gizmos.DrawRay(points[i], Vector3.up);

            //offsetX[partsPlusOne - i - 1] = Width * newVector;
            //offsetX[partsPlusOne - i - 1] = Vector3.up;
        }
    }
}


/// <summary>
/// This editor class will handle eveything editor related to StP, menu options, proper variable display for the component, etc.
/// </summary>
[CustomEditor(typeof(FloorCurveCreator))]
public class FloorCurveCreatorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        FloorCurveCreator StP = (FloorCurveCreator)target;
        DrawDefaultInspector();
        if (GUILayout.Button("Create"))
        {
            StP.Start();
        }
    }
}
