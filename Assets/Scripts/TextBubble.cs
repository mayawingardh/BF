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

    int randomNumber;

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
        GetRandomNumberPositive();
        ShowButton();
    }

    void ShowTextBubble1()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    void ShowTextBubble2()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    void ShowTextBubble3()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    void ShowTextBubble4()
    {
        GetRandomNumberPositive();
        ShowButton();
    }

    void ShowTextBubble5()
    {
        GetRandomNumberPositive();
        ShowButton();
    }

    void ShowButton()
    {
        textBubbleButton.SetActive(true);
        closeButton.SetActive(true);
    }

    void GetRandomNumberNegative()
    {
        randomNumber = UnityEngine.Random.Range(-1, -14);
    }

    void GetRandomNumberPositive()
    {
        randomNumber = UnityEngine.Random.Range(1, 5);

    }

    public void CloseTextBubble()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textBubbleButton.SetActive(false);
            closeButton.SetActive(false);
        }

        if(randomNumber == 1)
        {
            m_Object.text = "Insert Text Bubble text as appropriate";
        }
    }
}
