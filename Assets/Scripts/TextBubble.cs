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
            m_Object.text = "Om alla bytte ut ett kilo nyproducerad textil mot ett kilo second hand det kommande året, skulle det innebära att vi sparade minst 8 100 liter rent vatten per person.";
        }

        if (randomNumber == 2)
        {
            m_Object.text = "Genom att handla second hand utsätts du för mindre gifter. Kemikalierna, som tillsats vid tillverkningen av plagget eller prylen, har hunnit försvinna eller tvättats bort.";
        }

        if (randomNumber == 3)
        {
            m_Object.text = "Genom att handla i en Secondhand-butik med kopplingar till välgörenhet och socialt arbete bidrar din shopping till ett förbättrat samhälle.";
        }

        if (randomNumber == 4)
        {
            m_Object.text = "Om du handlar vart tionde plagg second hand minskar du dina växthusgasutsläpp med 30 kilo om året.";
        }

        if (randomNumber == 5)
        {
            m_Object.text = "Vid garvning av läder används ofta kemikalier med bland annat krom i. Genom att handla begagnade skor minskar du risken för att hälsofarliga kemikalier kommer i kontakt med din hud.";
        }

        if (randomNumber == -1)
        {
            m_Object.text = "Bomull står för ca 40-50 % av textiltillverkning i världen. Bomull odlas i torra områden med vattenbrist. Grundvattenytan sänks och lokalbefolkningens brunnar sinar. Floder och hela sjöar torkar ut.";
        }

        if (randomNumber == -2)
        {
            m_Object.text = "Ett par jeans kräver 12.000 liter vatten. Det är 5 år av dricksvatten till en person.";
        }

        if (randomNumber == -3)
        {
            m_Object.text = "Idag köper svenskarna i genomsnitt ca 13 kg textilier per person varje år (kläder och t.ex. hemtextil). Ett plagg i Sverige lever i genomsnitt ca 2,2 år.";
        }

        if (randomNumber == -4)
        {
            m_Object.text = "Mellan 10 000 och 30 000 liter går det åt för att producera 1 kilo textil.";
        }
        if (randomNumber == -5)
        {
            m_Object.text = "Svensken handlar mycket nytt i allmänhet, närmare bestämt 12,5 kilo nyproducerade kläder och hemtextilier per år, att jämföra med 0,9 kilo från second hand.";
        }

        if (randomNumber == -6)
        {
            m_Object.text = "1 av 6 personer jobbar inom arbeten kopplat till nyproduktion av kläder. 80% av dessa är kvinnor.";
        }

        if (randomNumber == -7)
        {
            m_Object.text = "Endast 5 av 250 stora varumärken som inspekterats i ”2020 Fashion Transparency Index” lever upp till kraven gällande minimilön för sina arbetare.";
        }

        if (randomNumber == -8)
        {
            m_Object.text = "100 miljarder klädesplagg produceras varje år. Det är 14 plagg per person.";
        }

        if (randomNumber == -9)
        {
            m_Object.text = "I snitt används ett klädesplagg bara 7 gånger. 3 av 5 plagg köpta inom ”fast fashion” hamnar på tippen inom ett år.";
        }

        if (randomNumber == -10)
        {
            m_Object.text = "90% av hela världens skoproduktion sker i Asien och produktionen kan ofta förknippas med miljöproblem samt dåliga arbetsförhållanden.";
        }

        if (randomNumber == -11)
        {
            m_Object.text = "Produktionen av läder är kemikalieintensivt. För ett kilo användbart läder går det åt upp till 250 liter vatten och 2,5 kg kemikalier.";
        }

        if (randomNumber == -12)
        {
            m_Object.text = "Skoindustrin beräknas stå för 1,5 % av världens föroreningar.";
        }

        if (randomNumber == -13)
        {
            m_Object.text = "15 miljarder skor produceras per år.";
        }

        if (randomNumber == -14)
        {
            m_Object.text = "Skoproduktionen bidrar till 1,3% av koldioxidutsläppen i världen. Det är alltså nästan lika mycket som utsläppen från flygresor som ligger på 2-3%.";
        }

    }
}
