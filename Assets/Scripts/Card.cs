using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
   public string cardName;
   public string cardFaction;
   public string cardType;
   public string cardAttackType;
   public string cardDescription;
   public int cardPower;
   public Sprite artwork;
   public Sprite cardAttackTypeIcon;
   public Sprite cardTypeIcon;
   public Sprite cardFactionIcon;
   public bool cardEffect;
}
