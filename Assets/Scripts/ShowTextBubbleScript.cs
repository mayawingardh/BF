using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextBubbleScript : MonoBehaviour
{
    [SerializeField] DragAndDrop square;
    [SerializeField] DragAndDrop square1;
    [SerializeField] DragAndDrop square2;
    [SerializeField] DragAndDrop square3;
    [SerializeField] DragAndDrop square4;
    [SerializeField] DragAndDrop square5;

    [SerializeField] GameObject textBubbleButton;
    [SerializeField] GameObject closeButton;

    private void OnEnable()
    {
        square.IsPlaced += ShowTextBubble;
        square1.IsPlaced += ShowTextBubble;
        square2.IsPlaced += ShowTextBubble;
        square3.IsPlaced += ShowTextBubble;
        square4.IsPlaced += ShowTextBubble;
        square5.IsPlaced += ShowTextBubble;
    }
    private void OnDisable()
    {
        square.IsPlaced -= ShowTextBubble;
        square2.IsPlaced -= ShowTextBubble;
        square3.IsPlaced -= ShowTextBubble;
        square4.IsPlaced -= ShowTextBubble;
        square5.IsPlaced -= ShowTextBubble;
    }

    void ShowTextBubble()
    {
        textBubbleButton.SetActive(true);
        closeButton.SetActive(true);
    }
}
