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

    void Start()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
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
        m_Object.text = "Insert text as appropriate";
    }
   
}
