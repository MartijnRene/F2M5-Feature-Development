using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] waypoint;

    public Waypoint GetPathStart()
    {
        return waypoint[0];
    }

    public Waypoint GetPathEnd()
    {
        return waypoint[waypoint.Length - 1];
    }
    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        for(int i = 0; i < waypoint.Length; i++)
        {
            if (waypoint[i] == currentWaypoint)
            {
                return waypoint[i + 1];
            }
        }
        return null;
    }
}
