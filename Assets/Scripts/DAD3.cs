using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DAD3 : MonoBehaviour
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
    private GameObject tre;

    [SerializeField]
    List<GameObject> newSocks;
    [SerializeField]
    List<GameObject> oldSocks;
    [SerializeField]
    Transform spawnNewSocks;
    [SerializeField]
    Transform spawnOldSocks;

    PointSystem pointSystemGameObject;

    protected static List<GameObject> destroyBottom;

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

        if (Vector2.Distance(transform.position, tre.transform.position) < 3 && gameObject.CompareTag("NewBottom"))
        {
            transform.position = tre.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(newSocks, spawnNewSocks);
            textBubble.ShowNewBottomTextBubble();
            pointSystemGameObject.BottomPoints = -1;

            destroyBottom ??= new List<GameObject>();

            if (destroyBottom.Count == 1)
            {

                destroyBottom[0].SetActive(false);
                destroyBottom = new List<GameObject>();

            }

            destroyBottom.Add(this.gameObject);
        }

        else if (Vector2.Distance(transform.position, tre.transform.position) < 3 && gameObject.CompareTag("OldBottom"))
        {
            transform.position = tre.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(oldSocks, spawnOldSocks);
            textBubble.ShowOldBottomTextBubble();
            pointSystemGameObject.BottomPoints = 1;

            destroyBottom ??= new List<GameObject>();

            if (destroyBottom.Count == 1)
            {

                destroyBottom[0].SetActive(false);
                destroyBottom = new List<GameObject>();

            }

            destroyBottom.Add(this.gameObject);
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
