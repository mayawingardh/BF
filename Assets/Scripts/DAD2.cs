using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DAD2 : MonoBehaviour
{
    TextBubble textBubble;
    SpawnManagerNewHat spawnManagerNewHat;
    //public Sounds soundsScript;


    public bool dragging, placed;

    //[SerializeField]
    //private AudioSource audioSource;
    //[SerializeField]
    //private AudioClip pickUpSound, dropSound;

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

    protected static List<GameObject> destroyTop;

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
        
       // soundsScript.PlayWrinkle();

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
           // soundsScript.PlayWrinkle();

            destroyTop ??= new List<GameObject>();

            if (destroyTop.Count == 1)
            {

                destroyTop[0].SetActive(false);
                destroyTop = new List<GameObject>();

            }

            destroyTop.Add(this.gameObject);
        }

        else if (Vector2.Distance(transform.position, tva.transform.position) < 3 && gameObject.CompareTag("NewTop"))
        {
            transform.position = tva.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(newTop, spawnNewTop);
            textBubble.ShowNewTopTextBubble();
            pointSystemGameObject.TopPoints = -1;
            //soundsScript.PlayWrinkle();

            destroyTop ??= new List<GameObject>();

            if (destroyTop.Count == 1)
            {

                destroyTop[0].SetActive(false);
                destroyTop = new List<GameObject>();

            }

            destroyTop.Add(this.gameObject);
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
