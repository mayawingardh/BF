using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TextBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] GameObject textBubbleButton;

    int randomNumber;

    void Start()
    {
        textBubbleButton.SetActive(false);
    }

    public void ShowNewHatTextBubble()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowOldHatTextBubble1()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowNewTopTextBubble()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowOldTopTextBubble()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowNewBottomTextBubble()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowOldBottomTextBubble()
    {
        GetRandomNumber();
        ShowButton();
    }

    public void ShowButton()
    {
        textBubbleButton.SetActive(true);
    }

    void GetRandomNumber()
    {
        randomNumber = UnityEngine.Random.Range(1, 19);
    }

    public void CloseTextBubble()
    {
        textBubbleButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textBubbleButton.SetActive(false);
        }

        if(randomNumber == 1)
        {
            m_Object.text = "Bomull star for ca 40-50 % av textiltillverkning i varlden. Bomull odlas i torra omraden med vattenbrist.";
        }

        if (randomNumber == 2)
        {
            m_Object.text = "Ett par jeans kraver 12.000 liter vatten vid tillverkning.";
        }

        if (randomNumber == 3)
        {
            m_Object.text = "Svensken koper ca 13 kg nya textilier varje ar. Endast 0,9kg secondhand.";
        }

        if (randomNumber == 4)
        {
            m_Object.text = "Ett plaggs genomsnittliga livslangd ar endast 2,2 ar.";
        }

        if (randomNumber == 5)
        {
            m_Object.text = "1 av 6 personer varlden over jobbar med nyproduktion av klader - 80% av dessa ar kvinnor.";
        }

        if (randomNumber == 6)
        {
            m_Object.text = "Endast 5 av 250 stora varumarken som inspekterats i ”2020 Fashion Transparency Index” lever upp till kraven gallande minimilon for anstallda.";
        }

        if (randomNumber == 7)
        {
            m_Object.text = "100 miljarder kladesplagg produceras varje ar. Det ar 14 plagg per person.";
        }

        if (randomNumber == 8)
        {
            m_Object.text = "I snitt anvands ett kladesplagg bara 7 ganger.";
        }

        if (randomNumber == 9)
        {
            m_Object.text = "3 av 5 plagg kopta inom ”fast fashion” hamnar pa tippen inom ett ar.";
        }
        if (randomNumber == 10)
        {
            m_Object.text = "Genom att byta ut ett kilo ny textil mot secondhand sparar vi 8.100 liter vatten.";
        }

        if (randomNumber == 11)
        {
            m_Object.text = "Secondhand = mindre gifter pa din hud. Mycket kemikalier vid tillverkning har hunnit tvattas bort.";
        }

        if (randomNumber == 12)
        {
            m_Object.text = "Nar du handlar hos exempelvis Bjork&Frihet bidrar du till bade valgorande andamal och socialt arbete.";
        }

        if (randomNumber == 13)
        {
            m_Object.text = "Genom att kopa vart tionde plagg secondhand minskar du dina vaxthusgasutslapp med 30kg per ar.";
        }

        if (randomNumber == 14)
        {
            m_Object.text = "90% av hela varldens skoproduktion sker i Asien. Ofta under daliga arbetsforhallanden.";
        }

        if (randomNumber == 15)
        {
            m_Object.text = "Produktionen av lader ar ofta kemikalieintensivt. For 1kg lader kravs 250 liter vatten och 2,5 kg kemikalier.";
        }

        if (randomNumber == 16)
        {
            m_Object.text = "Skoindustrin beraknas sta for 1,5 % av varldens fororeningar.";
        }

        if (randomNumber == 17)
        {
            m_Object.text = "15 miljarder skor produceras per ar.";
        }

        if (randomNumber == 18)
        {
            m_Object.text = "Skoproduktion bidrar till 1,3% av koldioxidutslappen i varlden. Nastan lika mycket som flygresor, som ligger pa 2-3%.";
        }

        if (randomNumber == 19)
        {
            m_Object.text = "Vid laderproduktion anvands bl.a kromsyra. Genom att handla begagnade skor slipper du exponeras for mycket av dessa kemikalier.";
        }

    }
}
