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

    int randomNumber;

    void Start()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    public void ShowTextBubble()
    {
        GetRandomNumberPositive();
        ShowButton();
    }

    public void ShowTextBubble1()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    public void ShowTextBubble2()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    public void ShowTextBubble3()
    {
        GetRandomNumberNegative();
        ShowButton();
    }

    public void ShowTextBubble4()
    {
        GetRandomNumberPositive();
        ShowButton();
    }

    public void ShowTextBubble5()
    {
        GetRandomNumberPositive();
        ShowButton();
    }

    public void ShowButton()
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
            m_Object.text = "Om alla bytte ut ett kilo nyproducerad textil mot ett kilo second hand det kommande �ret, skulle det inneb�ra att vi sparade minst 8 100 liter rent vatten per person.";
        }

        if (randomNumber == 2)
        {
            m_Object.text = "Genom att handla second hand uts�tts du f�r mindre gifter. Kemikalierna, som tillsats vid tillverkningen av plagget eller prylen, har hunnit f�rsvinna eller tv�ttats bort.";
        }

        if (randomNumber == 3)
        {
            m_Object.text = "Genom att handla i en Secondhand-butik med kopplingar till v�lg�renhet och socialt arbete bidrar din shopping till ett f�rb�ttrat samh�lle.";
        }

        if (randomNumber == 4)
        {
            m_Object.text = "Om du handlar vart tionde plagg second hand minskar du dina v�xthusgasutsl�pp med 30 kilo om �ret.";
        }

        if (randomNumber == 5)
        {
            m_Object.text = "Vid garvning av l�der anv�nds ofta kemikalier med bland annat krom i. Genom att handla begagnade skor minskar du risken f�r att h�lsofarliga kemikalier kommer i kontakt med din hud.";
        }

        if (randomNumber == -1)
        {
            m_Object.text = "Bomull st�r f�r ca 40-50 % av textiltillverkning i v�rlden. Bomull odlas i torra omr�den med vattenbrist. Grundvattenytan s�nks och lokalbefolkningens brunnar sinar. Floder och hela sj�ar torkar ut.";
        }

        if (randomNumber == -2)
        {
            m_Object.text = "Ett par jeans kr�ver 12.000 liter vatten. Det �r 5 �r av dricksvatten till en person.";
        }

        if (randomNumber == -3)
        {
            m_Object.text = "Idag k�per svenskarna i genomsnitt ca 13 kg textilier per person varje �r (kl�der och t.ex. hemtextil). Ett plagg i Sverige lever i genomsnitt ca 2,2 �r.";
        }

        if (randomNumber == -4)
        {
            m_Object.text = "Mellan 10 000 och 30 000 liter g�r det �t f�r att producera 1 kilo textil.";
        }
        if (randomNumber == -5)
        {
            m_Object.text = "Svensken handlar mycket nytt i allm�nhet, n�rmare best�mt 12,5 kilo nyproducerade kl�der och hemtextilier per �r, att j�mf�ra med 0,9 kilo fr�n second hand.";
        }

        if (randomNumber == -6)
        {
            m_Object.text = "1 av 6 personer jobbar inom arbeten kopplat till nyproduktion av kl�der. 80% av dessa �r kvinnor.";
        }

        if (randomNumber == -7)
        {
            m_Object.text = "Endast 5 av 250 stora varum�rken som inspekterats i �2020 Fashion Transparency Index� lever upp till kraven g�llande minimil�n f�r sina arbetare.";
        }

        if (randomNumber == -8)
        {
            m_Object.text = "100 miljarder kl�desplagg produceras varje �r. Det �r 14 plagg per person.";
        }

        if (randomNumber == -9)
        {
            m_Object.text = "I snitt anv�nds ett kl�desplagg bara 7 g�nger. 3 av 5 plagg k�pta inom �fast fashion� hamnar p� tippen inom ett �r.";
        }

        if (randomNumber == -10)
        {
            m_Object.text = "90% av hela v�rldens skoproduktion sker i Asien och produktionen kan ofta f�rknippas med milj�problem samt d�liga arbetsf�rh�llanden.";
        }

        if (randomNumber == -11)
        {
            m_Object.text = "Produktionen av l�der �r kemikalieintensivt. F�r ett kilo anv�ndbart l�der g�r det �t upp till 250 liter vatten och 2,5 kg kemikalier.";
        }

        if (randomNumber == -12)
        {
            m_Object.text = "Skoindustrin ber�knas st� f�r 1,5 % av v�rldens f�roreningar.";
        }

        if (randomNumber == -13)
        {
            m_Object.text = "15 miljarder skor produceras per �r.";
        }

        if (randomNumber == -14)
        {
            m_Object.text = "Skoproduktionen bidrar till 1,3% av koldioxidutsl�ppen i v�rlden. Det �r allts� n�stan lika mycket som utsl�ppen fr�n flygresor som ligger p� 2-3%.";
        }

    }
}
