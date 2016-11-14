﻿using UnityEngine;
using System.Collections;
using System;

public class Creep : Unit {
    public override UnitType getTypeUnit()
    {
        return UnitType.Creep;
    }

    protected int lane;
    public float offsetLane = 0.25f;
    protected float laneY()
    {
        return GSGamePlay.Instance.lanes[lane].position.y + offsetLane; ;
    }
}