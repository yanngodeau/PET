﻿using System;
using System.Threading;
using UnityEngine;

public class SetSettingsMod : Raspberry
{
    private void Start()
    {
        Debug.Log(GetUrlUpdateHeureDebut("A1", "debut"));
    }

    public String GetUrlUpdateHeureDebut(String codeModule, String debutOuFin)
    {
        String url = GetUrl();
        if (debutOuFin != "debut" && debutOuFin != "fin")
        {
            Debug.Log("Erreur nom variable (debut/fin)");
            return "";
        }
        switch (codeModule)
        {
            case "A1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleA1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleA1.minuteDebut;
                break;
            case "A2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleA2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleA2.minuteDebut;
                break;
            case "C1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC1.minuteDebut;
                break;
            case "C2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC2.minuteDebut;
                break;
            case "C3":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC3.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC3.minuteDebut;
                break;
            case "C4":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC4.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC4.minuteDebut;
                break;
            case "C5":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC5.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC5.minuteDebut;
                break;
            case "C6":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC6.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC6.minuteDebut;
                break;
            case "E1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE1.minuteDebut;
                break;
            case "E2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE2.minuteDebut;
                break;
            case "E3":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE3.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE3.minuteDebut;
                break;
            case "E4":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE4.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE4.minuteDebut;
                break;
            case "S1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleS1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleS1.minuteDebut;
                break;
            case "S2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + codeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleS2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleS2.minuteDebut;
                break;
            default:
                url = "";
                break;
        }

        return url;
    }

    public void UpdateVariableHeure(String codeModule, String debutOuFin)
    {
        String urlCreate =
            GetUrl() +
            "/json.htm?type=command&param=saveuservariable&vname=" + codeModule +
            "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleS2.heureDebut +
            ":" + GlobalControl.Instance.paramModuleS2.minuteDebut;
        Get(urlCreate);

        String urlUpdate = GetUrlUpdateHeureDebut(codeModule, debutOuFin);
        Get(urlUpdate);
    }
}