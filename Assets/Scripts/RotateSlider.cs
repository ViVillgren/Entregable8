using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSlider : MonoBehaviour
{

    //Variables para coger el Slider y añadir un maximo al que queramos rotar el objecto, en este caso en Y

    public Slider mySlider;
    public float yLimit = 180f;

    void Start()
    {
        //Al mover el Slider rotara el objeto
        mySlider.onValueChanged.AddListener(delegate { RotateMe(); });
    }

    public void RotateMe()
    {
        //Funcion para que el objecto rote segun el valor del Slider
        transform.localEulerAngles = new Vector3(0, mySlider.value * yLimit, 0);
    }
}
