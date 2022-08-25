using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DAD4 : MonoBehaviour
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
    private GameObject fyra;

    [SerializeField]
    List<GameObject> newPants;
    [SerializeField]
    List<GameObject> oldPants;
    [SerializeField]
    Transform spawnNewPants;
    [SerializeField]
    Transform spawnOldPants;

    PointSystem pointSystemGameObject;



    private void Awake()
    {
        OrgPos = transform.position;
        textBubble = FindObjectOfType<TextBubble>();
        spawnManagerNewHat = FindObjectOfType<SpawnManagerNewHat>();
    }

    private void Start()
    {
        mainCamera = Camera.main;
        pointSystemGameObject = FindObjectOfType<PointSystem>();
    }

    private void Update()
    {
        if (placed)
        {
            return;
        }

        if (!dragging)
        {
            return;
        }

        var mousePos = GetMousePos();

        transform.position = mousePos - offset;
    }

    private void OnMouseDown()
    {
        dragging = true;
        audioSource.PlayOneShot(pickUpSound);

        offset = GetMousePos() - (Vector2)transform.position;
    }

    private void OnMouseUp()
    {

        if (Vector2.Distance(transform.position, fyra.transform.position) < 3 && gameObject.CompareTag("NewPants"))
        {
            transform.position = fyra.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(newPants, spawnNewPants);
            textBubble.ShowNewBottomTextBubble();
            pointSystemGameObject.MiddlePoints = -1;
        }

        else if (Vector2.Distance(transform.position, fyra.transform.position) < 3 && gameObject.CompareTag("OldPants"))
        {
            transform.position = fyra.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(oldPants, spawnOldPants);
            textBubble.ShowOldBottomTextBubble();
            pointSystemGameObject.MiddlePoints = 1;
        }

        else
        {
            transform.position = OrgPos;
            dragging = false;
            audioSource.PlayOneShot(dropSound);
        }
    }

    Vector2 GetMousePos()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
