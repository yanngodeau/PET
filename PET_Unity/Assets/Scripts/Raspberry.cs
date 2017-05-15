using System;
using System.Collections;
using Newtonsoft.Json;
using UnityEngine;

/// <summary>
///
/// </summary>
public class Raspberry : MonoBehaviour
{
    private String _ip;
    private String _port;
    private RootObject _root; // RootObject du retour json

    void Start()
    {
        TestConnection("17.2.10.10", "8090");
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    public String GetIp()
    {
        return _ip;
    }

    public String GetPort()
    {
        return _port;
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
    /// Initialisation de la liste des devices à partir du retour JSON
    /// </summary>
    public void CreateDeviceList()
    {
        String url = GetUrl() + "/json.htm?type=devices";
        WWW www = Get(url);

        _root = JsonConvert.DeserializeObject<RootObject>(www.text);
        Debug.Log(_root);
    }

    /// <summary>
    /// Test la connexion avec le Raspberry
    /// </summary>
    /// <param name="ip">L'ip du raspberry</param>
    /// <param name="port">Le port utilisé comme</param>
    /// <returns>false si true si echec de connexion, false sinon</returns>
    public bool TestConnection(String ip, String port)
    {
        float timeOut = Time.time + 3;
        bool failed = false;

        String url = "http://" + ip + ":" + port + "/json.htm?type=command&param=getSunRiseSet";
        WWW www = new WWW(url);

        StartCoroutine(WaitForWWW(www));
        do
        {
            if (Time.time > timeOut)
            {
                failed = true;
                break;
            }
        } while (!www.isDone || www.error != null);
        if (failed)
        {
            Debug.Log("FAIL");
        }
        else
        {
            Debug.Log("SUCCESS");
        }
        return failed;
    }


    public WWW Get(string url)
    {
        WWW www = new WWW(url);
        float timeOut = Time.time + 10;
        bool failed = false;
        StartCoroutine(WaitForWWW(www));
        //do nothing untill json is loaded

        do
        {
            if (Time.time > timeOut)
            {
                failed = true;
                break;
            }
        } while (!www.isDone);

//        while (!www.isDone)
//        {
//
//        }

        if (failed)
        {
            return null;
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