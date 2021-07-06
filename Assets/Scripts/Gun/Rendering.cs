using System.Collections.Generic;
using UnityEngine;

public class Rendering : MonoBehaviour
{
    public int pointCount;
    [HideInInspector]
    public List<Vector3> points;
    [HideInInspector]
    public LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        points = new List<Vector3>();
        lineRenderer.positionCount = pointCount;
        for (int i = 0; i < pointCount; i++)
        {
            float time = i * 0.1f;
            points.Add(origin + speed * time + Physics.gravity * time * time / 2f);

            if (points[i].y < 0)
            {
                lineRenderer.positionCount = i;
                break;
            }
        }
        lineRenderer.SetPositions(points.ToArray());
    }
}