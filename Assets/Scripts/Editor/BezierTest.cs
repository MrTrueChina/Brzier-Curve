using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

[TestFixture]
public class BezierTest
{
    [Test]
    public void LengthSpeed()
    {
        int loopTimes = 1000000;

        Debug.Log("每次循环一次lengh，循环 " + loopTimes + " 次平均需要时间：" + GetLengthsTime(loopTimes) + "毫秒");
        Debug.Log("先获取length后循环，循环 " + loopTimes + " 次平均需要时间：" + GetOnceLengthTime(loopTimes) + "毫秒");
    }
    float GetLengthsTime(int length)
    {
        int[] array = new int[length];
        long time = 0;

        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        for (int loopTime = 0; loopTime < 10; loopTime++)
        {
            timer.Reset();
            timer.Start();
            for (int i = 0; i < array.Length; i++) { }
            timer.Stop();
            time += timer.ElapsedMilliseconds;
        }

        return (float)time / 10;
    }
    float GetOnceLengthTime(int length)
    {
        int[] array = new int[length];
        long time = 0;

        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        for (int loopTime = 0; loopTime < 10; loopTime++)
        {
            timer.Reset();
            timer.Start();
            int loopLength = array.Length;
            for (int i = 0; i < loopLength; i++) { }
            timer.Stop();
            time += timer.ElapsedMilliseconds;
        }

        return (float)time / 10;
    }
}
