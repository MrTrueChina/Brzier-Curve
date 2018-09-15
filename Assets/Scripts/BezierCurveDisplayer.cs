using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurveDisplayer : MonoBehaviour
{
    [SerializeField]
    Transform[] curveTransforms;

    private void OnDrawGizmos()
    {
        if (curveTransforms == null || curveTransforms.Length < 2) return;

        Vector3[] curvePoints = new Vector3[curveTransforms.Length];
        for (int i = 0; i < curvePoints.Length; i++)
            curvePoints[i] = curveTransforms[i].position;

        Vector3[] points = Bezier.GetBezierPointsWithOutEnd(40, curvePoints);

        for (int i = 0; i < points.Length - 1; i++)
            Gizmos.DrawLine(points[i], points[i + 1]);

        Gizmos.DrawLine(points[points.Length - 1], curvePoints[curvePoints.Length - 1]);
    }
}
