﻿using System;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : Raspberry
{
    private const string Ip = "172.20.10.10";
    private const string Port = "8080";
    public Switch Swt;
    public int Idx;

    private void Start()
    {
        if (Swt.isOn)
            SwitchOn();
        else
            SwitchOff();
    }

    public void Toggle()
    {
//        String url = GetUrl() + "/json.htm?type=command&param=switchlight&idx=" + idx + "5&switchcmd=Toggle";
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=command&param=switchlight&idx=" + Idx +
                     "&switchcmd=Toggle";
        WWW www = Get(url);
    }

    public void SwitchOn()
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=command&param=switchlight&idx=" + Idx +
                     "&switchcmd=On";
        WWW www = Get(url);
    }

    public void SwitchOff()
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=command&param=switchlight&idx=" + Idx +
                     "&switchcmd=Off";
        WWW www = Get(url);
    }

    public bool DeviceIsOn()
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=devices&rid=" + Idx;
        WWW www = Get(url);
        var device = JsonConvert.DeserializeObject<RootObject>(www.text);

        return device.result[0].Status == "On";
    }
}