﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PathDisplayMode { None, Connections, Paths }

public class AIWaypointNetwork : MonoBehaviour
{
    [HideInInspector] public PathDisplayMode DisplayMode = PathDisplayMode.Paths;
    [HideInInspector] public int UIStart = 0;
    [HideInInspector] public int UIEnd   = 0;
    public List<Transform> Waypoints = new List<Transform>();
}
