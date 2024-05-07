using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarritaMovil : MonoBehaviour
{
    public Transform puntoIzquerdo;
    public Transform puntoDerecho;
    public float velocidad = 5f;
    public bool haciaIzquerda = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (haciaIzquerda)
        {
            if (Vector3.Distance(puntoIzquerdo.position, transform.position) >= 0.01f)
            {
                transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);
            }
            else
            {
                haciaIzquerda = false;
            }
        }
        else
        {
            if (Vector3.Distance(puntoDerecho.position, transform.position) >= 0.01f)
            {
                transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
            }
            else
            {
                haciaIzquerda = true;
            }
        }
    }
}
