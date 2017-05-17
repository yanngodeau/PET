using System;
using System.Collections;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Cette classe gère la connexion avec le Raspberry.
/// Elle n'intervient que dans la scène Connexion
/// </summary>
public class ConnectionScript : MonoBehaviour
{
    [SerializeField] public InputField Ip;
    [SerializeField] public InputField Port;
    [SerializeField] public Raspberry Rpi;
    [SerializeField] public Text Retour;


    /// <summary>
    /// Onclick du bouton connexion de la page connextion.
    /// Initialise les attributs de la classe Raspberry (login, ip, ...)
    /// </summary>
    public void Connexion()
    {
        if (Ip.text != "" && Port.text != "" && ConnectionOK(Ip.text, Port.text))
        {
            Debug.Log("CONNECT SUCCESS");
            Rpi.SetIp(Ip.text);
            Rpi.SetPort(Port.text);
            Rpi.CreateDeviceList();
            Rpi.ConnectOK = true;
            SceneManager.LoadScene(28);
        }
        else
        {
            Retour.text = "<color=#ff3333>Echec de connexion</color>";
            Debug.Log("CONNECT FAILURE");
        }
    }


    /// <summary>
    /// Permet d'envoyer la requete http
    /// </summary>
    /// <param name="url"></param>
    /// <returns>WWW</returns>
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

    /// <summary>
    /// Test la connexion avec le Raspberry
    /// </summary>
    /// <param name="Ip">L'Ip du Raspberry</param>
    /// <param name="Port">Le Port</param>
    /// <returns>true si la connexion est bonne, false sinon</returns>
    public bool ConnectionOK(String Ip, String Port)
    {
        String url = "http://" + Ip + ":" + Port + "/json.htm?type=command&param=getSunRiseSet";
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
}