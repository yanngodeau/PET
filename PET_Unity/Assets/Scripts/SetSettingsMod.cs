using System;
using System.Threading;
using UnityEngine;

public class SetSettingsMod : Raspberry
{
    public String CodeModule;

    private String GetUrlUpdateHeure(String debutOuFin)
    {
        String url = GetUrl();
        switch (CodeModule)
        {
            case "A1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleA1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleA1.minuteDebut;
                break;
            case "A2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleA2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleA2.minuteDebut;
                break;
            case "C1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC1.minuteDebut;
                break;
            case "C2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC2.minuteDebut;
                break;
            case "C3":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC3.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC3.minuteDebut;
                break;
            case "C4":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC4.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC4.minuteDebut;
                break;
            case "C5":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC5.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC5.minuteDebut;
                break;
            case "C6":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleC6.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleC6.minuteDebut;
                break;
            case "E1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE1.minuteDebut;
                break;
            case "E2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE2.minuteDebut;
                break;
            case "E3":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE3.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE3.minuteDebut;
                break;
            case "E4":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleE4.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleE4.minuteDebut;
                break;
            case "S1":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleS1.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleS1.minuteDebut;
                break;
            case "S2":
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_heure_" + debutOuFin + "&vtype=4&vvalue=" + GlobalControl.Instance.paramModuleS2.heureDebut +
                       ":" + GlobalControl.Instance.paramModuleS2.minuteDebut;
                break;
            default:
                url = "";
                break;
        }

        return url;
    }

    public void UpdateVariableHeure()
    {
        if (!ConnectOK) return;

        String debutOuFin = "debut";

        String urlCreate =
            GetUrl() +
            "/json.htm?type=command&param=saveuservariable&vname=" + CodeModule +
            "_heure_" + debutOuFin + "&vtype=4&vvalue=0:0";
        Get(urlCreate);

        String urlUpdate = GetUrlUpdateHeure(debutOuFin);
        Get(urlUpdate);


        debutOuFin = "fin";

        urlCreate =
            GetUrl() +
            "/json.htm?type=command&param=saveuservariable&vname=" + CodeModule +
            "_heure_" + debutOuFin + "&vtype=4&vvalue=0:0";
        Get(urlCreate);

        urlUpdate = GetUrlUpdateHeure(debutOuFin);
        Get(urlUpdate);
    }


    private String GetUrlUpdateJour(String jour)
    {
        String url = GetUrl();
        String etat = "false";


        switch (CodeModule)
        {
            case "A1":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleA1.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleA1.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleA1.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleA1.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleA1.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleA1.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleA1.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "A2":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleA2.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleA2.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleA2.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleA2.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleA2.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleA2.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleA2.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "C1":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC1.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC1.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC1.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC1.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC1.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC1.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC1.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "C2":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC2.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC2.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC2.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC2.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC2.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC2.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC2.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "C3":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC3.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC3.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC3.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC3.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC3.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC3.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC3.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "C4":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC4.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC4.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC4.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC4.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC4.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC4.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC4.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "C5":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC5.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC5.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC5.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC5.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC5.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC5.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC5.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "C6":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC6.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC6.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC6.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC6.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC6.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC6.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC6.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "E1":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleE1.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleE1.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleE1.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleE1.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleE1.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleE1.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleE1.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "E2":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleE2.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleE2.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleE2.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleE2.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleE2.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleE2.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleE2.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "E3":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleE3.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleE3.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleE3.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleE3.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleE3.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleE3.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleE3.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "E4":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC3.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC3.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC3.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC3.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC3.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC3.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC3.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;


            case "S1":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC3.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC3.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC3.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC3.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC3.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC3.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC3.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            case "S2":
                switch (jour)
                {
                    case "lundi":
                        if (GlobalControl.Instance.paramModuleC3.lundiOn) etat = "true";
                        break;

                    case "mardi":
                        if (GlobalControl.Instance.paramModuleC3.mardiOn) etat = "true";
                        break;

                    case "mercredi":
                        if (GlobalControl.Instance.paramModuleC3.mercrediOn) etat = "true";
                        break;

                    case "jeudi":
                        if (GlobalControl.Instance.paramModuleC3.jeudiOn) etat = "true";
                        break;

                    case "vendredi":
                        if (GlobalControl.Instance.paramModuleC3.vendrediOn) etat = "true";
                        break;

                    case "samedi":
                        if (GlobalControl.Instance.paramModuleC3.samediOn) etat = "true";
                        break;

                    case "dimanche":
                        if (GlobalControl.Instance.paramModuleC3.dimancheOn) etat = "true";
                        break;

                    default:
                        etat = "";
                        break;
                }
                url += "/json.htm?type=command&param=updateuservariable&vname=" + CodeModule +
                       "_jour_" + jour + "&vtype=2&vvalue=" + etat;
                break;

            default:
                url = "";
                break;
        }

        return url;
    }

    public void UpdateVariablesJours()
    {
        if (!ConnectOK) return;

        String[] jours = {"lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche"};
        foreach (var jour in jours)
        {
            String urlCreate =
                GetUrl() +
                "/json.htm?type=command&param=saveuservariable&vname=" + CodeModule +
                "_jour_" + jour + "&vtype=2&vvalue=false";
            Get(urlCreate);

            String urlUpdate = GetUrlUpdateJour(jour);
            Get(urlUpdate);
        }
    }
}