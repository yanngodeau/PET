using System;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSensor : Raspberry
{
    private const string Ip = "172.20.10.10";
    private const string Port = "8080";
    public int Idx;
    public Text Retour;

    private void Update()
    {
        Retour.text = GetDataSensor();
    }

    private String GetDataSensor()
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=devices&rid=" + Idx;
        WWW www = Get(url);
        var device = JsonConvert.DeserializeObject<RootObject>(www.text);

        return device.result[0].Data;
    }
}