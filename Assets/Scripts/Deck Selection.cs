using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckSelection : MonoBehaviour
{
    public GameObject _factionNorth;
    public GameObject _factionCrown;
    public GameObject _factionTargaryen;
    public GameObject _factionGreyjoy;
    public GameObject _factionWatch;
    public GameObject _factionBaratheon;
    public GameObject _playerStatus;
    public static string _player1Faction;
    public static string _player2Faction;
    public static bool _player1Deck = true;
    public GameObject _card;
    public Transform _deck;
    public Transform _collection;
    public void SendToDeck()
    {
     if (_card.transform.parent == _collection)
     {
        _card.transform.parent = _deck;
        if (_player1Deck)
        {
            DeckScript.deck1.Add(CardDatabase.cardList[_card.GetComponent<DisplayCard>().id]);            
        }
        else
        {
            DeckScript.deck2.Add(CardDatabase.cardList[_card.GetComponent<DisplayCard>().id]);            
        }
        Debug.Log(DeckScript.deck1.Count);
        Debug.Log(DeckScript.deck2.Count);
     }
     else if (_card.transform.parent == _deck)
     {
        _card.transform.parent = _collection;
        if (_player1Deck)
        {
            DeckScript.deck1.Remove(CardDatabase.cardList[_card.GetComponent<DisplayCard>().id]);
        }
        else
        {
            DeckScript.deck2.Remove(CardDatabase.cardList[_card.GetComponent<DisplayCard>().id]);
        }
        Debug.Log(DeckScript.deck1.Count);
        Debug.Log(DeckScript.deck2.Count);
     }
    }
    public void SendAllToCollection()
    {
        List<Transform> deckChildren = GetChildren(_deck);
        foreach (Transform child in deckChildren)
        {
            child.transform.parent = _collection;
        }
    }
    public void RemoveAll()
    {     
         if (_player1Deck)
        {
            DeckScript.deck1.Clear();
            Debug.Log(DeckScript.deck1.Count);
        }
        else
        {
            DeckScript.deck2.Clear();
            Debug.Log(DeckScript.deck2.Count);
        }
    }    
    public void player2()
    {
        _player1Deck = false;
    }
    public void P1SelectFaction()
    {
        if (_factionNorth.activeSelf)
        {
            _player1Faction = "The North";
        }
        else if (_factionCrown.activeSelf)
        {
            _player1Faction = "The Crown";
        }
        else if (_factionTargaryen.activeSelf)
        {
            _player1Faction = "Targaryen";
        }
        else if (_factionGreyjoy.activeSelf)
        {
            _player1Faction = "Greyjoy";
        }
        else if (_factionWatch.activeSelf)
        {
            _player1Faction = "Watch";
        }
        else if (_factionBaratheon.activeSelf)
        {
            _player1Faction = "Baratheon";
        }
        Debug.Log(_player1Faction);
    }
    public void P2SelectFaction()
    {
        if (_factionNorth.activeSelf)
        {
            _player2Faction = "The North";
        }
        else if (_factionCrown.activeSelf)
        {
            _player2Faction = "The Crown";
        }
        else if (_factionTargaryen.activeSelf)
        {
            _player2Faction = "Targaryen";
        }
        else if (_factionGreyjoy.activeSelf)
        {
            _player2Faction = "Greyjoy";
        }
        else if (_factionWatch.activeSelf)
        {
            _player2Faction = "Watch";
        }
        else if (_factionBaratheon.activeSelf)
        {
            _player2Faction = "Baratheon";
        }
        Debug.Log(_player2Faction);
    }
    List<Transform> GetChildren(Transform parent)
    {
        List<Transform> children = new List<Transform>();

        foreach (Transform child in parent)
        {
            children.Add(child);
        }
        return children;
    }
}
