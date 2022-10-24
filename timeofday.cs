using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeofday : MonoBehaviour
{
    public GameObject Night;
    public GameObject Day;
    public GameObject VSleeping;
    public GameObject Spider;
    public GameObject Fox;
    public GameObject BabyFox;
    public GameObject BabyCat;
    public GameObject Cat;

    public void Time(){

        Night.SetActive(true);
        Day.SetActive(false);
        Spider.SetActive(true);
        VSleeping.SetActive(true);
        Cat.SetActive(false);
        Fox.SetActive(false);
        BabyCat.SetActive(false);
        BabyFox.SetActive(false);
    }
}
