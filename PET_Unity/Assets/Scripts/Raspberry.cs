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
    /// Affiche l'url
    ///         http://{ip}:{port}
    /// </summary>
    public void DebugUrl()
    {
        Debug.Log("http://" + GetLogin() + GetPass() + ":" + GetPort());
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns>L'url http://{ip}:{port}</returns>
    public String GetUrl()
    {
        return "http://" + GetIp() + ":" + GetPort();
    }


    public void CreateDeviceList()
    {
        String url = "http://" + GetIp() + ":" + GetPort() + "/json.htm?type=devices";
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
        _deviceslist = JsonConvert.DeserializeObject<List<Device>>(www.text);
        Debug.Log(_deviceslist);
    }

    public IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
}