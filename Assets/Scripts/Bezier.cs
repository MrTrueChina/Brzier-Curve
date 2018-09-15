using UnityEngine;
using System.Collections.Generic;

public class Bezier
{
    public static Vector3[] GetBezierPoints(int pointsNumber, params Vector3[] curvePoints)
    {
        List<Vector3> points = new List<Vector3>();

        points.AddRange(GetBezierPointsWithOutEnd(pointsNumber, curvePoints));
        points.Add(curvePoints[curvePoints.Length - 1]);

        return points.ToArray();
    }
    public static Vector3[] GetBezierPointsWithOutEnd(int pointsNumber, params Vector3[] curvePoints)
    {
        Vector3[] points = new Vector3[pointsNumber];

        for (int i = 0; i < pointsNumber; i++)
        {
            float rate = (float)i / pointsNumber;
            points[i] = GetBezierPoint(rate, curvePoints);
        }

        return points;
    }

    public static Vector3 GetBezierPoint(float rate, params Vector3[] points)
    {
        if (points.Length < 1) return Vector3.zero;
        
        while (points.Length > 1)
            points = GetNextPoints(rate, points);

        return points[0];
    }
    static Vector3[] GetNextPoints(float rate, Vector3[] points)
    {
        Vector3[] newPoints = new Vector3[points.Length - 1];

        for (int i = 0; i < newPoints.Length; i++)
            newPoints[i] = Vector3.Lerp(points[i], points[i + 1], rate);

        return newPoints;
    }
}