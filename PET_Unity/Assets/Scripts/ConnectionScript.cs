using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Cette classe gère la connexion avec le Raspberry.
/// Elle n'intervient que dans la scène Connexion
/// </summary>
public class ConnectionScript : MonoBehaviour
{
    [SerializeField] public InputField Login;
    [SerializeField] public InputField Pass;
    [SerializeField] public InputField Ip;
    [SerializeField] public InputField Port;
    [SerializeField] public Raspberry Rpi;
    [SerializeField] public Text Retour;

    /// <summary>
    /// Retourne le texte saisi dans l'InputField Port
    /// </summary>
    /// <returns>Port.text : String</returns>
    public String GetPortInput()
    {
        return Port.text;
    }


    /// <summary>
    /// Retourne le texte saisi dans l'InputField Ip
    /// </summary>
    /// <returns>Ip.text : String</returns>
    public String GetIpInput()
    {
        return Ip.text;
    }


    /// <summary>
    /// Retourne le texte saisi dans l'InputField Login
    /// </summary>
    /// <returns>Login.text : String</returns>
    public String GetLoginInput()
    {
        return Login.text;
    }


    /// <summary>
    /// Retourne le texte saisi dans l'InputField Mdp
    /// </summary>
    /// <returns>Pass.text : String</returns>
    public String GetPassInput()
    {
        return Pass.text;
    }

    /// <summary>
    /// Onclick du bouton connexion de la page connextion.
    /// Initialise les attributs de la classe Raspberry (login, ip, ...)
    /// </summary>
    public void Connexion()
    {
        if (Ip.text != "" && Port.text != "" && ConnectTest(Ip.text, Port.text))
        {
            Debug.Log("CONNECT SUCCESS");
            Rpi.SetIp(Ip.text);
            Rpi.SetPort(Port.text);
            Rpi.SetLogin(Login.text);
            Rpi.SetPass(Pass.text);
            Rpi.CreateDeviceList();
            SceneManager.LoadScene(1);
        }
        else
        {
            Retour.text = "<color=#ff3333>Echec de connexion</color>";
            Debug.Log("CONNECT FAILURE");
        }
    }

    /// <summary>
    /// Test la connexion avec le raspberry
    /// </summary>
    /// <param name="ip"> IP du Raspberry</param>
    /// <param name="port">Port du Raspberry</param>
    /// <returns>ture si la connexion est bonne, false sinon</returns>
    private bool ConnectTest(String ip, String port)
    {
        String url = "http://" + ip + ":" + port + "/json.htm?type=command&param=getSunRiseSet";
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));

        return www.error == null;
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