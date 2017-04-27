using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

/// <summary>
///
/// </summary>
public class Raspberry : MonoBehaviour
{
    private String _login;
    private String _pass;
    private String _ip;
    private String _port;
    private List<Device> _deviceslist;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public String GetLogin()
    {
        return _login;
    }

    public String GetPass()
    {
        return _pass;
    }

    public String GetIp()
    {
        return _ip;
    }

    public String GetPort()
    {
        return _port;
    }


    public void SetLogin(String login)
    {
        _login = login;
    }

    public void SetPass(String pass)
    {
        _pass = pass;
    }

    public void SetIp(String ip)
    {
        _ip = ip;
    }

    public void SetPort(String port)
    {
        _port = port;
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
    ///
    /// </summary>
    public void CreateDeviceList()
    {
        String url = GetUrl() + "/json.htm?type=devices";
        WWW www = Get(url);
        _deviceslist = JsonConvert.DeserializeObject<List<Device>>(www.text);
        Debug.Log(_deviceslist);
    }

    private WWW Get(string url)
    {
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