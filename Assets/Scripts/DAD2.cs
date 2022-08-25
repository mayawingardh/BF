using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DAD2 : MonoBehaviour
{
    public event Action NewTopPlaced = delegate { };
    public event Action OldTopPlaced = delegate { };


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
            //OldTopPlaced.Invoke();
        }

        else if (Vector2.Distance(transform.position, tva.transform.position) < 3 && gameObject.CompareTag("NewTop"))
        {
            transform.position = tva.transform.position;
            placed = true;
            //NewTopPlaced.Invoke();
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
