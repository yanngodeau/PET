using System;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSensor : Raspberry
{
    public int Idx;
    public Text Retour;
    public bool IsTemp; // On si bouton température
    public bool IsHum; // On si bouton humidité


    private void Awake()
    {
        if (!ConnectOK) return;
        if (IsTemp)
        {
            var temphum = GetDataSensor();
            var vals = SplitTempHum(temphum);
            Retour.text = vals[0];
        }
        else if (IsHum)
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
    /// <returns>String[] vals : Le tableau contenant les 2 valeurs</returns>
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

        if (www != null)
        {
            var device = JsonConvert.DeserializeObject<RootObject>(www.text);
            return device.result[0].Data;
        }
        return "N/A";
    }
}