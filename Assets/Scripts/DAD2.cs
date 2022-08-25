using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DAD2 : MonoBehaviour
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
    private GameObject tva;

    [SerializeField]
    List<GameObject> newTop;
    [SerializeField]
    List<GameObject> oldTop;
    [SerializeField]
    Transform spawnNewTop;
    [SerializeField]
    Transform spawnOldTop;

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

        if (Vector2.Distance(transform.position, tva.transform.position) < 3 && gameObject.CompareTag("oldTop"))
        {
            transform.position = tva.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(oldTop, spawnOldTop);
            textBubble.ShowOldTopTextBubble();
            pointSystemGameObject.TopPoints = 1;
            Debug.Log("TopPoints");
            Debug.Log(pointSystemGameObject.TopPoints);
        }

        else if (Vector2.Distance(transform.position, tva.transform.position) < 3 && gameObject.CompareTag("NewTop"))
        {
            transform.position = tva.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(newTop, spawnNewTop);
            textBubble.ShowNewTopTextBubble();
            pointSystemGameObject.TopPoints = -1;
            Debug.Log("TopPoints");
            Debug.Log(pointSystemGameObject.TopPoints);

        }
        else
        {
            transform.position = OrgPos;
            dragging = false;
            //audioSource.PlayOneShot(dropSound);
        }
    }

    Vector2 GetMousePos()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
