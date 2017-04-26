using System;
using UnityEngine;

public abstract class Device : MonoBehaviour
{
    public Raspberry Rpi;
    private int idx;
    private String Name;
    private String _room;

    protected Device(Raspberry rpi, int idx, string name, string room)
    {
        Rpi = rpi;
        this.idx = idx;
        Name = name;
        _room = room;
    }

    public void SetRpi(Raspberry rpi)
    {
        Rpi = rpi;
    }

    public void SetIdx(int idx)
    {
        this.idx = idx;
    }

    public void SetName(String devicename)
    {
        Name = devicename;
    }

    public int GetIdx()
    {
        return idx;
    }

    public String GetName()
    {
        return Name;
    }

    public Raspberry GetRaspberry()
    {
        return Rpi;
    }
}