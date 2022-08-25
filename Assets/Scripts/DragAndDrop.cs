using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragAndDrop : MonoBehaviour
{
    public event Action NewHatPlaced = delegate { };
    public event Action OldHatPlaced = delegate { };

    private bool dragging, placed;

    [SerializeField] 
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip pickUpSound, dropSound;

    private Camera mainCamera;
    private Vector2 offset;
    private Vector2 OrgPos;

    [SerializeField]
    private GameObject ett;
   
    private void Awake()
    {
        OrgPos = transform.position;
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (placed)
        {
            return;
        }

        if(!dragging)
        {
            return;
        }

        var mousePos = GetMousePos();

        transform.position = mousePos- offset;
    }

    private void OnMouseDown()
    {
        dragging = true;
        //audioSource.PlayOneShot(pickUpSound);

        offset = GetMousePos() - (Vector2) transform.position;
    }

    private void OnMouseUp()
    {

        if (Vector2.Distance(transform.position, ett.transform.position) < 3 && gameObject.CompareTag("NewHat"))
        {
            transform.position = ett.transform.position;
            placed = true;
            NewHatPlaced.Invoke();
        }

        else if (Vector2.Distance(transform.position, ett.transform.position) < 3 && gameObject.CompareTag("oldhat"))
        {
            transform.position = ett.transform.position;
            placed = true;
           // OldHatPlaced.Invoke();
        }
        else
        {
            transform.position = OrgPos;
            dragging = false;
            //audioSource.PlayOneShot(dropSound);
        }  
    }

    //todo. OLIKA KLADER OLIKA POANG, KAN BARA SATTAS P� VISSA STALLEN

    Vector2 GetMousePos ()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition); 
    }
}
