using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI text;
    public TMPro.TMP_InputField giris;

    void Start()
    {
        text.text = PlayerPrefs.GetString("ad");
        giris.text = PlayerPrefs.GetString("ad");
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.Return))
        {
            kaydet();
        }


    }
    public void kaydet()
    {
        PlayerPrefs.SetString("ad", giris.text);
        text.text = PlayerPrefs.GetString("ad");

    }
 
}