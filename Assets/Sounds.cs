using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    DragAndDrop dragScript;
    DAD2 dad2;
    DAD3 dad3;
    DAD4 dad4;
    AudioSource audioSource;
    public AudioClip wrinkleClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dragScript = FindObjectOfType<DragAndDrop>();
        dad2 = FindObjectOfType<DAD2>();
        dad3 = FindObjectOfType<DAD3>();
        dad4 = FindObjectOfType<DAD4>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayWrinkle()
    {
        if (dragScript.dragging || dad2.dragging || dad3.dragging || dad4.dragging )
        {
            audioSource.PlayOneShot(wrinkleClip);
        }
    }
}
