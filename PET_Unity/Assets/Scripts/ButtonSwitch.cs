using System;
using System.Net;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : Raspberry
{
    public int Idx;
    public Button Btn;
    public Color ColorOn;
    public Color ColorOff;

    void Update()
    {
        if (ConnectOK)
        {
            Btn.image.color = DeviceIsOn() ? ColorOn : ColorOff;
        }
    }

    public void Toggle()
    {
        if (!ConnectOK) return;
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

        if (www != null)
        {
            var device = JsonConvert.DeserializeObject<RootObject>(www.text);
            return device.result[0].Status == "On" && device.status == "OK";
        }
        return false;
    }
}