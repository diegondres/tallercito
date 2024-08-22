using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float startTime;
    private float elapsedTime;
    private UIController uIController;

    void Awake()
    {
        // Guardar el tiempo en que comienza la aplicación
        startTime = Time.time;
        uIController = FindObjectOfType<UIController>();
    }

    void Update()
    {
        // Calcular el tiempo transcurrido desde el inicio
        elapsedTime = Time.time - startTime;
         // Calcular minutos y segundos
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);
 
        uIController.UpdateTiempo(minutes.ToString("00") + ":" + seconds.ToString("00"));
    }

    public void UpdateVidas(int vidas){
        uIController.UpdateVidas(vidas);
    }

}
