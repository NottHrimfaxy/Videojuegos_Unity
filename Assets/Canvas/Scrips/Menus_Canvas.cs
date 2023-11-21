using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus_Canvas : MonoBehaviour
{
     
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject levelSelectPanel;


    public void OpenPanel (GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
    }
}
