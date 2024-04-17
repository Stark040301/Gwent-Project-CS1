using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeckScript : MonoBehaviour
{
    //Deck Images
    public Sprite _deck1Sprite;
    public Sprite _deck2Sprite;
    public Image _deck1Image;
    public Image _deck2Image;
    //Faction Leader Images
    public Sprite _leader1Sprite;
    public Sprite _leader2Sprite;
    public Image _leader1Image;
    public Image _leader2Image;
    //Faction Icon
    public Sprite _faction1Sprite;
    public Sprite _faction2Sprite;
    public Image _faction1Image;
    public Image _faction2Image;
    //Faction Name
    public TMP_Text _faction1Name;
    public TMP_Text _faction2Name;
    string _north = "The North";
    string _crown = "The Crown";
    string _targaryen = "Targaryen";
    string _greyjoy = "Greyjoy";
    string _watch = "Watch";
    string _baratheon = "Baratheon";
    public static List<Card> deck1 = new List<Card>();
    public static List<Card> deck2 = new List<Card>();

    void Start()
    {
        if (DeckSelection._player1Faction == _north)
        {
            _deck1Sprite = Resources.Load<Sprite>("The North Deck");
            _leader1Sprite = Resources.Load<Sprite>("Robb Stark");
            _faction1Sprite = Resources.Load<Sprite>("The North Sigil");
            _faction1Name.text = "El Norte";
        }
        else if (DeckSelection._player1Faction == _crown)
        {
            _deck1Sprite = Resources.Load<Sprite>("The Crown Deck");            
            _leader1Sprite = Resources.Load<Sprite>("Joffrey");
            _faction1Sprite = Resources.Load<Sprite>("The Crown Sigil");
            _faction1Name.text = "La Corona";
            
        }
        else if (DeckSelection._player1Faction == _targaryen)
        {
            _deck1Sprite = Resources.Load<Sprite>("Targaryen Deck");            
            _leader1Sprite = Resources.Load<Sprite>("Danny");
            _faction1Sprite = Resources.Load<Sprite>("Targaryen Sigil");
            _faction1Name.text = "Targaryen";
        }
        else if (DeckSelection._player1Faction == _greyjoy)
        {
            _deck1Sprite = Resources.Load<Sprite>("Greyjoy Deck");            
            _leader1Sprite = Resources.Load<Sprite>("Balon");
            _faction1Sprite = Resources.Load<Sprite>("Greyjoy Sigil");
            _faction1Name.text = "Greyjoy";
        }
        else if (DeckSelection._player1Faction == _watch)
        {
            _deck1Sprite = Resources.Load<Sprite>("Watch Deck");            
            _leader1Sprite = Resources.Load<Sprite>("Jon");
            _faction1Sprite = Resources.Load<Sprite>("Watch Sigil");
            _faction1Name.text = "Guardia de la Noche";
        }
        else if (DeckSelection._player1Faction == _baratheon)
        {
            _deck1Sprite = Resources.Load<Sprite>("Baratheon Deck");            
            _leader1Sprite = Resources.Load<Sprite>("Stannis");
            _faction1Sprite = Resources.Load<Sprite>("Baratheon Sigil");
            _faction1Name.text = "Baratheon";
        }
        
        _deck1Image.sprite = _deck1Sprite;        
        _leader1Image.sprite = _leader1Sprite;
        _faction1Image.sprite = _faction1Sprite;

        if (DeckSelection._player2Faction == _north)
        {
            _deck2Sprite = Resources.Load<Sprite>("The North Deck");
            _leader2Sprite = Resources.Load<Sprite>("Robb Stark");
            _faction2Sprite = Resources.Load<Sprite>("The North Sigil");
            _faction2Name.text = "El Norte";
        }
        else if (DeckSelection._player2Faction == _crown)
        {
            _deck2Sprite = Resources.Load<Sprite>("The Crown Deck");            
            _leader2Sprite = Resources.Load<Sprite>("Joffrey");
            _faction2Sprite = Resources.Load<Sprite>("The Crown Sigil");
            _faction2Name.text = "La Corona";
        }
        else if (DeckSelection._player2Faction == _targaryen)
        {
            _deck2Sprite = Resources.Load<Sprite>("Targaryen Deck");            
            _leader2Sprite = Resources.Load<Sprite>("Danny");
            _faction2Sprite = Resources.Load<Sprite>("Targaryen Sigil");
            _faction2Name.text = "Targaryen";
        }
        else if (DeckSelection._player2Faction == _greyjoy)
        {
            _deck2Sprite = Resources.Load<Sprite>("Greyjoy Deck");            
            _leader2Sprite = Resources.Load<Sprite>("Balon");
            _faction2Sprite = Resources.Load<Sprite>("Greyjoy Sigil");
            _faction2Name.text = "Greyjoy";
        }
        else if (DeckSelection._player2Faction == _watch)
        {
            _deck2Sprite = Resources.Load<Sprite>("Watch Deck");            
            _leader2Sprite = Resources.Load<Sprite>("Jon");
            _faction2Sprite = Resources.Load<Sprite>("Watch Sigil");
            _faction2Name.text = "Guardia de la Noche";
        }
        else if (DeckSelection._player2Faction == _baratheon)
        {
            _deck2Sprite = Resources.Load<Sprite>("Baratheon Deck");            
            _leader2Sprite = Resources.Load<Sprite>("Stannis");
            _faction2Sprite = Resources.Load<Sprite>("Baratheon Sigil");
            _faction2Name.text = "Baratheon";
        }
        
        _deck2Image.sprite = _deck2Sprite;
        _leader2Image.sprite = _leader2Sprite;
        _faction2Image.sprite = _faction2Sprite;
    }
}
