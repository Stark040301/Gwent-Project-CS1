using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffects : MonoBehaviour
{
    public static void Blizzard()
    {
        foreach (Card card in PowerCount._melee1List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
        foreach (Card card in PowerCount._melee2List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
    }
    public static void Fog()
    {
        foreach (Card card in PowerCount._ranged1List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
        foreach (Card card in PowerCount._ranged2List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
    }
    public static void Rain()
    {
        foreach (Card card in PowerCount._siege1List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
        foreach (Card card in PowerCount._siege2List)
        {
            if (card.cardType != "Héroe" & card.cardPower != 0)
            {
                card.cardPower = 1;
            }
        }
    }
    public static void M1Buff()
    {
        foreach (Card card in PowerCount._melee1List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void M2Buff()
    {
        foreach (Card card in PowerCount._melee2List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void R1Buff()
    {
        foreach (Card card in PowerCount._ranged1List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void R2Buff()
    {
        foreach (Card card in PowerCount._ranged2List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void S1Buff()
    {
        foreach (Card card in PowerCount._siege1List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void S2Buff()
    {
        foreach (Card card in PowerCount._siege2List)
        {
            if (card.cardType != "Héroe")
            {
                card.cardPower = card.dupCardPower;
            }
        }
    }
    public static void Rename()
    {

    }
}
