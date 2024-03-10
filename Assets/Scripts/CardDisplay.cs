using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public TMP_Text cardNameText;
   public TMP_Text cardDescriptionText;
   public TMP_Text cardPowerText;
   public Image artworkImage;
   public Image cardAttackTypeIconImage;
   public Image cardTypeIconImage;
   public Image cardFactionIconImage;
    void Start()
    {
        cardNameText.text = card.cardName;
        cardDescriptionText.text = card.cardDescription;
        //cardPowerText.text = card.cardPower.ToString();
        artworkImage.sprite = card.artwork;
        //cardAttackTypeIconImage.sprite = card.cardAttackTypeIcon;
        //cardTypeIconImage.sprite = card.cardTypeIcon;
        cardFactionIconImage.sprite = card.cardFactionIcon;
    }
}
