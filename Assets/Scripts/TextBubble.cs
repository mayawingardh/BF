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

    [SerializeField] DragAndDrop square;
    [SerializeField] DragAndDrop square1;
    [SerializeField] DragAndDrop square2;
    [SerializeField] DragAndDrop square3;
    [SerializeField] DragAndDrop square4;
    [SerializeField] DragAndDrop square5;

    private void OnEnable()
    {
        square.IsPlaced += ShowTextBubble;
        square1.IsPlaced += ShowTextBubble1;
        square2.IsPlaced += ShowTextBubble2;
        square3.IsPlaced += ShowTextBubble3;
        square4.IsPlaced += ShowTextBubble4;
        square5.IsPlaced += ShowTextBubble5;
    }
    private void OnDisable()
    {
        square.IsPlaced -= ShowTextBubble;
        square1.IsPlaced -= ShowTextBubble;
        square2.IsPlaced -= ShowTextBubble;
        square3.IsPlaced -= ShowTextBubble;
        square4.IsPlaced -= ShowTextBubble;
        square5.IsPlaced -= ShowTextBubble;
    }

    void Start()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    void ShowTextBubble()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text as appropriate";
    }

    void ShowTextBubble1()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text 1 as appropriate";

    }

    void ShowTextBubble2()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text 2 as appropriate";
    }

    void ShowTextBubble3()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text 3 as appropriate";
    }

    void ShowTextBubble4()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text 4 as appropriate";

    }

    void ShowTextBubble5()
    {
        ShowButton();
        m_Object.text = "Insert Text Bubble text 5 as appropriate";

    }

    void ShowButton()
    {
        textBubbleButton.SetActive(true);
        closeButton.SetActive(true);
    }

    public void CloseTextBubble()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    //public void ClickTextBubble()
    //{
    //    m_Object.text = "Insert text as appropriate";
    //}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textBubbleButton.SetActive(false);
            closeButton.SetActive(false);
        }
    }
}
