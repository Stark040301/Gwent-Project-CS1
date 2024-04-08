using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplaySCard : MonoBehaviour
{
    public List<Card> displaySCard = new List<Card>();
    public int displayId;

    public int id;
    public int cardAttackType;

   public Sprite cardArtwork;
   public Sprite cardEffectIcon;

   public Image cardArtworkImage;
   public Image cardEffectIconImage;           

    void Start()
    {
        Debug.Log(CardDatabase.cardList.Count);
        Debug.Log(displaySCard.Count);
        displaySCard.Add(CardDatabase.cardList[displayId]);
        Debug.Log(displaySCard.Count);
    }

    void Update()
    {
        id = displaySCard[0].id;
        cardAttackType = displaySCard[0].cardAttackType;
        cardArtwork = displaySCard[0].cardArtwork;
        cardEffectIcon = displaySCard[0].cardEffectIcon;
        
        cardArtworkImage.sprite = cardArtwork;
        cardEffectIconImage.sprite = cardEffectIcon;     
    }
}
