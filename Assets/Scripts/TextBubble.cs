using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TextBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] GameObject textBubbleButton;
    [SerializeField] GameObject closeButton;

    public DragAndDrop dragAndDrop2;

    //public GameObject gameManager;
    //SpawnManager spawnManager;

    private void OnEnable()
    {
        //dragAndDrop2.IsPlaced += ShowTextBubble();
    }
    private void OnDisable()
    {
        //dragAndDrop2.IsPlaced -= ShowTextBubble();
    }


    void Start()
    {
        //spawnManager = gameManager.GetComponent<SpawnManager>();
        m_Object.text = "Text Bubble";
    }

    

    void ShowTextBubble()
    {
        textBubbleButton.SetActive(true);
        closeButton.SetActive(true);
    }

    public void CloseTextBubble()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    public void ClickTextBubble()
    {
        m_Object.text = "Test if close icon stays in correct position";
    }

    private void Update()
    {
        
    }
}
