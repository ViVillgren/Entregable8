using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDescription : MonoBehaviour
{
    public GameObject descriptiontext;

    void Start()
    {
        descriptiontext.SetActive(false);
    }

    public void OnMouseOver()
    {
        descriptiontext.SetActive(true);
    }

    public void OnMouseExit()
    {
        descriptiontext.SetActive(false);
    }
}
