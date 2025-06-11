using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sene : MonoBehaviour
{
    public GameObject ayarlarpanel;
    public GameObject menupanel;
    void Start()
    {
        ayarlarpanel.SetActive(false);
        menupanel.SetActive(true);

    }

    // Update is called once per frame
    public void ayarlarýac()
    {
        ayarlarpanel.SetActive(true);
        menupanel.SetActive(false);
    }

    public void menupanelac()
    {
        ayarlarpanel.SetActive(false);
        menupanel.SetActive(true);  
    }

    public void oyunuac()
    {
        SceneManager.LoadScene(1);
    }

    public void menugec()
    {
        SceneManager.LoadScene(0);
    }

}
