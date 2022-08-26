using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragAndDrop : MonoBehaviour
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
    private GameObject ett;

    [SerializeField]
    List<GameObject> newHat;
    [SerializeField]
    List<GameObject> oldHat;
    [SerializeField]
    Transform spawnNewHat;
    [SerializeField]
    Transform spawnOldHat;

    PointSystem pointSystemGameObject;

    protected static List<GameObject> destroyHat;

    private void Awake()
    {
        textBubble = FindObjectOfType<TextBubble>();
        spawnManagerNewHat = FindObjectOfType<SpawnManagerNewHat>();
        OrgPos = transform.position;
        
    }

    private void Start()
    {
        pointSystemGameObject = FindObjectOfType<PointSystem>();
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
        
        offset = GetMousePos() - (Vector2)transform.position;
        //soundsScript.PlayWrinkle();


    }

    private void OnMouseUp()
    {


        if (Vector2.Distance(transform.position, ett.transform.position) < 3 && gameObject.CompareTag("NewHat"))
        {
            transform.position = ett.transform.position;
            placed = true;
            //soundsScript.PlayWrinkle();
            spawnManagerNewHat.spawnNewGarment(newHat, spawnNewHat);
            textBubble.ShowNewHatTextBubble();
            pointSystemGameObject.HatPoints = -1;

            destroyHat ??= new List<GameObject>();

            if (destroyHat.Count == 1)
            {

                destroyHat[0].SetActive(false);
                destroyHat = new List<GameObject>();

            }


            destroyHat.Add(this.gameObject);
        }

        else if (Vector2.Distance(transform.position, ett.transform.position) < 3 && gameObject.CompareTag("oldhat"))
        {
            transform.position = ett.transform.position;
            placed = true;
            spawnManagerNewHat.spawnNewGarment(oldHat, spawnOldHat);
            textBubble.ShowOldHatTextBubble1();
            pointSystemGameObject.HatPoints = 1;
            //soundsScript.PlayWrinkle();

            destroyHat ??= new List<GameObject>();

            if (destroyHat.Count == 1)
            {

                destroyHat[0].SetActive(false);
                destroyHat = new List<GameObject>();

            }

            destroyHat.Add(this.gameObject);
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
