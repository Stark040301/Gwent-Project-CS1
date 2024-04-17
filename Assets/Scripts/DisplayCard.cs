using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public int cardPower;
    public int cardAttackType;

   public Sprite cardArtwork;
   public Sprite cardAttackIcon;
   public Sprite cardEffectIcon;

   public TMP_Text cardPowerText;
   public Image cardArtworkImage;
   public Image cardAttackTypeImage;
   public Image cardEffectIconImage;           

    void Start()
    {
        displayCard.Add(CardDatabase.cardList[displayId]);
    }

    void Update()
    {
        id = displayCard[0].id;
        cardPower = displayCard[0].cardPower;
        cardAttackType = displayCard[0].cardAttackType;
        cardArtwork = displayCard[0].cardArtwork;
        cardAttackIcon = displayCard[0].cardAttackIcon;
        cardEffectIcon = displayCard[0].cardEffectIcon;

        cardPowerText.text = " " + cardPower;
        
        cardArtworkImage.sprite = cardArtwork;
        cardAttackTypeImage.sprite = cardAttackIcon;
        cardEffectIconImage.sprite = cardEffectIcon;     
    }
}
