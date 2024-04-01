using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public List<Card> cardDisplay = new List<Card>();
    public int displayId;

    public int id;
    public int cardPower;
    public int cardAttackType;
    public string cardName;
    public string cardDescription;
   public string cardType;
   public string cardEffect;

/*    public Sprite cardArtwork;
   public Sprite cardAttackTypeIcon;
   public Sprite cardTypeIcon;
   public Sprite cardTypeIconHero;
   public Sprite cardEffectIcon;  */  

   public TMP_Text cardPowerText;
   public TMP_Text cardAttackTypeText;
   public TMP_Text cardNameText;
   public TMP_Text cardDescriptionText;
   public TMP_Text cardTypeText;
   public TMP_Text cardEffectText;
/*    public Image cardArtworkImage;
   public Image cardAttackTypeIconImage;
   public Image cardTypeIconImage;
   public Image cardTypeIconHeroImage;
   public Image cardEffectIconImage; */            

    void Start()
    {
        cardDisplay[0] = CardDatabase.cardList[displayId];
    }

    void Update()
    {
        id = cardDisplay[0].id;
        cardPower = cardDisplay[0].cardPower;
        cardAttackType = cardDisplay[0].cardAttackType;
        cardName = cardDisplay[0].cardName;
        cardDescription = cardDisplay[0].cardDescription;
        cardType = cardDisplay[0].cardType;
        cardEffect = cardDisplay[0].cardEffect;

        cardPowerText.text = " " + cardPower;
        cardAttackTypeText.text = " " + cardAttackType;
        cardNameText.text = " " + cardName;
        cardDescriptionText.text = " " + cardDescription;
        cardTypeText.text = " " + cardType;
        cardEffectText.text = " " + cardEffect;
        
/*         cardArtworkImage.sprite = cardArtwork;
        cardAttackTypeIconImage.sprite = cardAttackTypeIcon;
        cardTypeIconImage.sprite = cardTypeIcon;
        cardTypeIconHeroImage.sprite = cardTypeIconHero;
        cardEffectIconImage.sprite = cardEffectIcon;  */       
    }
}
