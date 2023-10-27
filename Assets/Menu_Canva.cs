using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Canva : MonoBehaviour
{
       public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego_Canva");
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
