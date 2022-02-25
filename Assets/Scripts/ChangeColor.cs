using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    //Variables para coger el cubo, cambiar el render del cubo y los canaales de color para hacerlo aleatorio.
    [SerializeField] private GameObject cube;
    private Renderer cubeRenderer;
    private Color newCubeColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    void Start()
    {
        //funcion cada vez que clickemos el boton el gameObject cambiara a un color aleatorio 
        cubeRenderer = cube.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeColor);
    }

    private void ChangeCubeColor()
    {

        //canales de colores que se aplicara uno aleatoriamente cada vez que clickemos el boton
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCubeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        cubeRenderer.material.SetColor("_Color", newCubeColor);
    }
}
