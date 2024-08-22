using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TMP_Text contadorTiempoText;
    public TMP_Text contadorVidas;

    public void UpdateTiempo(string textContador)
    {
        contadorTiempoText.text = textContador;
    }

    public void UpdateVidas(int vidas)
    {
        contadorVidas.text = "Vidas: " + vidas;
    }
}
