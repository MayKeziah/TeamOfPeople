using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    // The number of seconds before the time is up
    private float maxTime;

    // The start and end time of the timer
    private float start;
    private float end;

    public Timer()
    {
        maxTime = 1f;
        end = -1f;
    }

    public void startTimer()
    {
        start = Time.time;
        end = start + maxTime;
    }

    public bool timeIsUp()
    {
        return Time.time >= end;
    }

    public void setDuration(float duration)
    {
        maxTime = duration;
    }

}
