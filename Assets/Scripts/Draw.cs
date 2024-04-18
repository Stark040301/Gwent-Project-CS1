using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draw : MonoBehaviour
{
    public Transform _hand1;
    public Transform _hand2;
    public Transform _reDraw1;
    public Transform _reDraw2;  
    public GameObject _heroCard;
    public GameObject _silverCard;
    public GameObject _specialCard;
    public static List<Card> _hand1List = new List<Card>();
    public static List<Card> _hand2List = new List<Card>();

    void Start()
    {
        Draw10Cards();
        Debug.Log("Deck 1: " + DeckScript.deck1.Count);
        Debug.Log("Deck 2: " + DeckScript.deck2.Count);
        Debug.Log("Hand 1: " + _hand1List.Count);
        Debug.Log("Hand 2: " + _hand2List.Count);
    }
    public void Draw10Cards()
    {
        for (int i = 0; i < 10; i++)
        {
            int index1 = Random.Range(0, DeckScript.deck1.Count - 1);
            int index2 = Random.Range(0, DeckScript.deck2.Count - 1);
            _hand1List.Add(DeckScript.deck1[index1]);
            _hand2List.Add(DeckScript.deck2[index2]);
            DeckScript.deck1.RemoveAt(index1);
            DeckScript.deck2.RemoveAt(index2);           
        }
        int h1 = 0;
        int p1 = 0;
        int s1 = 0;
        int h2 = 0;
        int p2 = 0;
        int s2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (_hand1List[i].cardType == "Héroe")
            {
                h1++;
                Instantiate(_heroCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[i].id;
            }
            else if (_hand1List[i].cardType == "Plata")
            {
                p1++;
                Instantiate(_silverCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[i].id;
            }
            else
            {
                s1++;
                Instantiate(_specialCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[i].id;
            }
            if (_hand2List[i].cardType == "Héroe")
            {
                h2++;
                Instantiate(_heroCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[i].id;
            }
            else if (_hand2List[i].cardType == "Plata")
            {
                p2++;
                Instantiate(_silverCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[i].id;
            }
            else
            {
                s2++;
                Instantiate(_specialCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[i].id;
            }
        }
        Debug.Log("Hero1: " + h1);
        Debug.Log("Plata1: " + p1);
        Debug.Log("Special1: " + s1);
        Debug.Log("Hero2: " + h2);
        Debug.Log("Plata2: " + p2);
        Debug.Log("Special2: " + h2);
    }
    public void P1Draw2Cards()
    {
        for (int i = 0; i < 2; i++)
        {
            int index1 = Random.Range(0, DeckScript.deck1.Count - 1);
            _hand1List.Add(DeckScript.deck1[index1]);
            DeckScript.deck1.RemoveAt(index1);
        }
    }
    public void P2Draw2Cards()
    {
        for (int i = 0; i < 2; i++)
        {
            int index2 = Random.Range(0, DeckScript.deck2.Count - 1);
            _hand2List.Add(DeckScript.deck2[index2]);
            DeckScript.deck2.RemoveAt(index2);
        }
    }
    public void P1Draw1Card()
    {
       int index1 = Random.Range(0, DeckScript.deck1.Count - 1);
        _hand1List.Add(DeckScript.deck1[index1]);
        DeckScript.deck1.RemoveAt(index1);
        int indexNew = _hand1List.Count - 1;
        if (_hand1List[indexNew].cardType == "Héroe")
        {
            Instantiate(_heroCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;
        }
        else if (_hand1List[indexNew].cardType == "Plata")
        {
            Instantiate(_silverCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;
        }
        else
        {
            Instantiate(_specialCard, _hand1).GetComponent<DisplayCard>().displayId = _hand1List[indexNew].id;            
        }
    }
    public void P2Draw1Card()
    {
        int index2 = Random.Range(0, DeckScript.deck2.Count - 1);
        _hand2List.Add(DeckScript.deck2[index2]);
        DeckScript.deck2.RemoveAt(index2);
        int indexNew = _hand2List.Count - 1;
        if (_hand2List[indexNew].cardType == "Héroe")
        {
            Instantiate(_heroCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[indexNew].id;
        }
        else if (_hand2List[indexNew].cardType == "Plata")
        {
            Instantiate(_silverCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[indexNew].id;
        }
        else
        {
            Instantiate(_specialCard, _hand2).GetComponent<DisplayCard>().displayId = _hand2List[indexNew].id;            
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
