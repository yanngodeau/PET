using System;
using System.Collections;
using System.Net;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

/// <summary>
///
/// </summary>
public class Raspberry : MonoBehaviour
{
    public String Ip = "172.20.10.10";
    public String Port = "8080";
    private RootObject _root; // RootObject du retour json
    public bool ConnectOK;

    void Awake()
    {
        ConnectOK = ConnectionOK();
        DontDestroyOnLoad(transform.gameObject);
    }


    public String GetIp()
    {
        return Ip;
    }

    public String GetPort()
    {
        return Port;
    }


    public void SetIp(String ip)
    {
        Ip = ip;
    }

    public void SetPort(String port)
    {
        Port = port;
    }

    /// <summary>
    /// Retourne l'url du raspberry
    /// </summary>
    /// <returns>L'url http://{ip}:{port}</returns>
    public String GetUrl()
    {
        return "http://" + GetIp() + ":" + GetPort();
    }


    /// <summary>
    /// Initialisation de la liste des devices à partir du retour JSON
    /// </summary>
    public void CreateDeviceList()
    {
        String url = GetUrl() + "/json.htm?type=devices";
        WWW www = Get(url);

        _root = JsonConvert.DeserializeObject<RootObject>(www.text);
        Debug.Log(_root);
    }

    public bool ConnectionOK()
    {
        String url = GetUrl() + "/json.htm?type=command&param=getSunRiseSet";
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        request.Timeout = 1000;

        try
        {
            WebResponse response = request.GetResponse();
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return false;
        }

        return true;
    }

    public WWW Get(string url)
    {
        if (!ConnectionOK())
        {
            return null;
        }
        WWW www = new WWW(url);

        StartCoroutine(WaitForWWW(www));
        //do nothing untill json is loaded
        while (!www.isDone)
        {
        }

        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log("WWW OK : = " + www.text);
        }
        else
        {
            Debug.Log("WWW error: " + www.error);
        }

        return www;
    }

    IEnumerator WaitForWWW(WWW www)
    {
        yield return www;
    }
}