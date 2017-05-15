using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

public class HourModule : Raspberry
{
    private const string Ip = "172.20.10.10";
    private const string Port = "8080";
    public int IdxStartVar;
    public int IdxEndVar;
    public String NumModule;
    private int _startHour;
    private int _startMin;
    private int _stopHour;
    private int _stopMin;




    public void SetStartHour(int newHour)
    {
        String url =
            "http://" + Ip + ":" + Port +
            "/json.htm?type=command&param=updateuservariable&idx=" + IdxStartVar + "&vname=" + NumModule +
            "_heure_debut&vtype=4&vvalue=" + newHour + ":" + _startMin;

        Get(url);
        _startHour = newHour;
    }

    public void SetStartMin(int newMin)
    {
        String url =
            "http://" + Ip + ":" + Port +
            "/json.htm?type=command&param=updateuservariable&idx=" + IdxStartVar + "&vname=" + NumModule +
            "_heure_debut&vtype=4&vvalue=" + _startHour + ":" + newMin;

        Get(url);
        _startMin = newMin;
    }


    public void SetStopHour(int newHour)
    {
        String url =
            "http://" + Ip + ":" + Port +
            "/json.htm?type=command&param=updateuservariable&idx=" + IdxEndVar + "&vname=" + NumModule +
            "_heure_debut&vtype=4&vvalue=" + newHour + ":" + _stopHour;

        Get(url);
        _stopHour = newHour;
    }

    public void SetStopMin(int newMin)
    {
        String url =
            "http://" + Ip + ":" + Port +
            "/json.htm?type=command&param=updateuservariable&idx=" + IdxEndVar + "&vname=" + NumModule +
            "_heure_debut&vtype=4&vvalue=" + _stopHour + ":" + newMin;

        Get(url);
        _startHour = newMin;
    }
}