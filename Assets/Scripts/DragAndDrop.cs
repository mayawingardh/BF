using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragAndDrop : MonoBehaviour
{
    TextBubble textBubble;
    SpawnManagerNewHat spawnManagerNewHat;

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

    [SerializeField]
    List<GameObject> newHat;
    [SerializeField]
    List<GameObject> oldHat;
    [SerializeField]
    Transform spawnNewHat;
    [SerializeField]
    Transform spawnOldHat;

    public int points;
   
    private void Awake()
    {
        textBubble = FindObjectOfType<TextBubble>();
        spawnManagerNewHat = FindObjectOfType<SpawnManagerNewHat>();
        OrgPos = transform.position;
    }

    private void Start()
    {
        mainCamera = Camera.main;
        points = 0;
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
            spawnManagerNewHat.spawnNewGarment(newHat, spawnNewHat);
            textBubble.ShowNewHatTextBubble();
            points = points + 1;
            Debug.Log(points);
        }

        else if (Vector2.Distance(transform.position, ett.transform.position) < 3 && gameObject.CompareTag("oldhat"))
        {
            transform.position = ett.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(oldHat, spawnOldHat);
            textBubble.ShowOldHatTextBubble1();
            points = points - 1;
            Debug.Log(points);

        }
        else
        {
            transform.position = OrgPos;
            dragging = false;
            //audioSource.PlayOneShot(dropSound);
        }  
    }

    Vector2 GetMousePos ()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition); 
    }
}
