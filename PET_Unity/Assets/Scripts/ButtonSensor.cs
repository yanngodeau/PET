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
    public bool isTemp; // On si bouton température
    public bool isHum; // On si bouton humidité

    private void Awake()
    {
        if (isTemp)
        {
            var temphum = GetDataSensor();
            var vals = SplitTempHum(temphum);
            Retour.text = vals[0];
        }
        else if (isHum)
        {
            var temphum = GetDataSensor();
            var vals = SplitTempHum(temphum);
            Retour.text = vals[1];
        }
        else
        {
            Retour.text = GetDataSensor();
        }

    }

    /// <summary>
    /// Permet de séparer les valeurs température et humidité
    /// </summary>
    /// <param name="temphum"></param>
    /// <returns>String[] vals</returns>
    public String[] SplitTempHum(String temphum)
    {
        var vals = temphum.Split(',');
        return vals;
    }

    /// <summary>
    /// Retourne la valeur du capteur
    /// </summary>
    /// <returns>String data</returns>
    private String GetDataSensor()
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=devices&rid=" + Idx;
        WWW www = Get(url);
        var device = JsonConvert.DeserializeObject<RootObject>(www.text);

        return device.result[0].Data;
    }
}