using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draw : MonoBehaviour
{
    public Transform _hand1;
    public Transform _hand2;
    public Transform _deck1;
    public Transform _deck2;    
    public Transform _reDraw1;
    public Transform _reDraw2;  
    public GameObject _heroCard;
    public GameObject _silverCard;
    public GameObject _specialCard;

    void Start()
    {
        InstantiateDecks();
        Draw10Cards();
    }
    public void Draw10Cards()
    {
        for (int i = 0; i < 10; i++)
        {
            _deck1.GetChild(Random.Range(0, _deck1.childCount - 1)).parent = _hand1;
            _deck2.GetChild(Random.Range(0, _deck2.childCount - 1)).parent = _hand2;
        }
    }

    public void InstantiateDecks()
    {
        for (int i = 0; i < DeckScript.deck1.Count; i++)
        {
            if (DeckScript.deck1[i].cardType == "Héroe")
            {
                Instantiate(_heroCard, _deck1).GetComponent<DisplayCard>().displayId = DeckScript.deck1[i].id;
            }
            else if (DeckScript.deck1[i].cardType == "Plata")
            {
                Instantiate(_silverCard, _deck1).GetComponent<DisplayCard>().displayId = DeckScript.deck1[i].id;
            }
            else
            {
                Instantiate(_specialCard, _deck1).GetComponent<DisplayCard>().displayId = DeckScript.deck1[i].id;
            }
        }
        for (int i = 0; i < DeckScript.deck2.Count; i++)
        {
            if (DeckScript.deck2[i].cardType == "Héroe")
            {
                Instantiate(_heroCard, _deck2).GetComponent<DisplayCard>().displayId = DeckScript.deck2[i].id;
            }
            else if (DeckScript.deck2[i].cardType == "Plata")
            {
                Instantiate(_silverCard, _deck2).GetComponent<DisplayCard>().displayId = DeckScript.deck2[i].id;
            }
            else
            {
                Instantiate(_specialCard, _deck2).GetComponent<DisplayCard>().displayId = DeckScript.deck2[i].id;
            }            
        }
    }
    /*public void P1ReDraw()
    {
        int index1 = Random.Range(0, DeckScript.deck1.Count - 1);
        _hand1List.Add(DeckScript.deck1[index1]);
        DeckScript.deck1.RemoveAt(index1);
        int indexNew = _hand1List.Count - 1;
        if (_hand1List[indexNew].cardType == "Héroe")
        {
            Instantiate(_heroCard, _reDraw1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;
        }
        else if (_hand1List[indexNew].cardType == "Plata")
        {
            Instantiate(_silverCard, _reDraw1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;
        }
        else
        {
            Instantiate(_specialCard, _reDraw1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;            
        }
        DeckScript.deck1.Add(CardDatabase.cardList[EventSystems.EventSystem-currentSelectedGameObject.GetComponent<DisplayCard>.displayId]);
        for (int i = 0; i < _hand1List.Count; i++)
        {
            if (_hand1List[i].id == EventSystems.EventSystem-currentSelectedGameObject.GetComponent<DisplayCard>.displayId)
            {
                _hand1List.RemoveAt(i);
            }
        }
    }*/
}
