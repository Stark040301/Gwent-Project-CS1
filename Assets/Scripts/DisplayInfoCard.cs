using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayInfoCard : MonoBehaviour
{
    public List<Card> displayInfoCard = new List<Card>();
    public int displayId;

    public int id;
    public int cardPower;
    public int cardAttackType;
    public string cardName;
    public string cardDescription;
   public string cardType;
   public string cardEffect;

   public Sprite cardArtwork;
   public Sprite cardAttackIcon;
   public Sprite cardEffectIcon; 

   public TMP_Text cardNameText;
   public TMP_Text cardDescriptionText;
   public TMP_Text cardPowerText;
   public TMP_Text cardEffectText;      
   public TMP_Text cardTypeText;
   public Image cardArtworkImage;
   public Image cardAttackTypeImage;
   public Image cardEffectIconImage;           

    void Start()
    {
        Debug.Log(CardDatabase.cardList.Count);
        Debug.Log(displayInfoCard.Count);
        displayInfoCard.Add(CardDatabase.cardList[displayId]);
        Debug.Log(displayInfoCard.Count);
    }

    void Update()
    {
        id = displayInfoCard[0].id;
        cardPower = displayInfoCard[0].cardPower;
        cardAttackType = displayInfoCard[0].cardAttackType;
        cardName = displayInfoCard[0].cardName;
        cardDescription = displayInfoCard[0].cardDescription;
        cardType = displayInfoCard[0].cardType;
        cardEffect = displayInfoCard[0].cardEffect;
        cardArtwork = displayInfoCard[0].cardArtwork;
        cardAttackIcon = displayInfoCard[0].cardAttackIcon;
        cardEffectIcon = displayInfoCard[0].cardEffectIcon;

        cardNameText.text = " " + cardName;
        cardDescriptionText.text = " " + cardDescription;
        cardPowerText.text = " " + cardPower;
        cardEffectText.text = " " + cardEffect;                
        cardTypeText.text = " " + cardType;
        
        cardArtworkImage.sprite = cardArtwork;
        cardAttackTypeImage.sprite = cardAttackIcon;
        cardEffectIconImage.sprite = cardEffectIcon;     
    }
}
