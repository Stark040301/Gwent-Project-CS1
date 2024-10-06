using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardsinDeckUI : MonoBehaviour
{
    public GameObject _p1Red;
    public GameObject _p1Green;
    public GameObject _p2Red;
    public GameObject _p2Green;    
    public TMP_Text _cardsInDeck1;
    public TMP_Text _cardsInDeck2;
    public GameObject _cardsInDeckP1;    
    public GameObject _cardsInDeckP2; 
    void Update()
    {
        _cardsInDeck1.text = " " + DeckScript.deck1.Count;
        _cardsInDeck2.text = " " + DeckScript.deck2.Count;
        if (DeckScript.deck1.Count >= 25)    
        {   
            _p1Green.SetActive(true);
            _p1Red.SetActive(false);
        }
        else
        {
            _p1Green.SetActive(false);
            _p1Red.SetActive(true);
        }

        if (DeckScript.deck2.Count >= 25)    
        {   
            _p2Green.SetActive(true);
            _p2Red.SetActive(false);
        }
        else
        {
            _p2Green.SetActive(false);
            _p2Red.SetActive(true);
        }
    }

    public void ActivateCID()
    {
        if (DeckScript.deck1.Count >= 25)
        {
            _cardsInDeckP1.SetActive(false);
            _cardsInDeckP2.SetActive(true);
        }
    }
}
