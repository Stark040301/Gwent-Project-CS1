using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
   //public int cardPowerHero;
   public int id;
   public int cardPower;
   public int dupCardPower;
   public int cardAttackType;
   public string cardName;
   public string cardDescription;
   public string cardType;
   public string cardEffect;
   public Sprite cardArtwork;
   public Sprite cardAttackIcon;
   public Sprite cardEffectIcon;
   //public bool cardEffect;


   public Card()
   {

   }

   public Card(int Id, string Name, int Power, int AttackType, string Description, string Type, string Effect, Sprite Artwork, Sprite AttackIcon, Sprite EffectIcon)
   {
    id = Id;
    cardName = Name;
    cardPower = Power;
    dupCardPower = 2 * Power;
    cardAttackType = AttackType;
    cardDescription = Description;
    cardType = Type;
    cardEffect = Effect;
    cardArtwork = Artwork;
    cardAttackIcon = AttackIcon;
    cardEffectIcon = EffectIcon;
   }
}
