using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Script qui regroupe des variables ensembles pour les sauvegarder/charger ensemble

public class SwitchsModules
{
    public bool SwitchPrincipal = true;
    public bool Switch2 = true;
    public bool Switch3 = true;
    public bool Switch4 = true;
}

public class ParametresModules
{
    public int valeurDropdown = 0;
    public bool lundiOn = false;
    public bool mardiOn = false;
    public bool mercrediOn = false;
    public bool jeudiOn = false;
    public bool vendrediOn = false;
    public bool samediOn = false;
    public bool dimancheOn = false;
    public int heureDebut = 0;
    public int minuteDebut = 0;
    public int heureFin = 0;
    public int minuteFin = 0;
}

public class ParametresTaches
{
    public bool tache1Terminee = false;
    public bool tache2Terminee = false;
    public bool tache3Terminee = false;
    public bool tache4Terminee = false;
    public bool tache5Terminee = false;
    public bool tache6Terminee = false;
    public bool tache7Terminee = false;
    public bool tache8Terminee = false;
}