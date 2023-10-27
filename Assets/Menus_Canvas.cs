using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus_Canvas : MonoBehaviour
{
    [Header ("Options")]
    public slider volumeFx;
    public slider volumeMaster;
    public toggle Mute;    
    [Header ("Panels")]
    public GameObject mainpanel;
    public GameObject optionsPanel;
    public GameObject levelSelectPanel;


    public void OpenPanel (GameObject panel);
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);

        panel.SetActive(true);
    }

}
