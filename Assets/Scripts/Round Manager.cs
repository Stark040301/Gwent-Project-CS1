using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public static int P1Score;
    public static int P2Score;
    public GameObject _p1Life1;
    public GameObject _p2Life1;
    public GameObject _gameOver1;
    public GameObject _gameOver2;    
    public GameObject _heroCard;
    public GameObject _silverCard;
    public GameObject _specialCard;
    public GameObject _rgo;
    public GameObject _prButton1;
    public GameObject _prButton2;
    public GameObject _ohand1;
    public GameObject _ohand2;
    public Transform _deck1;
    public Transform _deck2;
    public Transform _hand1;
    public Transform _hand2;
    public Transform _weather;
    public Transform _melee1;
    public Transform _mbuff1;
    public Transform _ranged1;
    public Transform _rbuff1;
    public Transform _siege1;
    public Transform _sbuff1;
    public Transform _melee2;
    public Transform _mbuff2;
    public Transform _ranged2;
    public Transform _rbuff2;
    public Transform _siege2;
    public Transform _sbuff2;
    public Transform _graveyard1;
    public Transform _graveyard2; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DiscardExtra();
    }
    
    public void RoundChecker1()
    {
        if (_rgo.activeSelf)
        {
            _rgo.SetActive(false);
            _prButton1.SetActive(false);
            _prButton2.SetActive(true);
            _ohand1.SetActive(false);
            _ohand2.SetActive(true);
        }
        else
        {
            EndRound();
        }
    }

    public void RoundChecker2()
    {
        if (_rgo.activeSelf)
        {
            _rgo.SetActive(false);
            _prButton2.SetActive(false);
            _prButton1.SetActive(true);
            _ohand2.SetActive(false);
            _ohand1.SetActive(true);
        }
        else
        {
            EndRound();
        }
    }

    public void EndRound()
    {
        if (PowerCount.P1RoundWinner)
        {
            P1Score++;
            _prButton2.SetActive(false);
            _prButton1.SetActive(true);
            _ohand2.SetActive(false);
            _ohand1.SetActive(true);
            _rgo.SetActive(true);
            _p2Life1.SetActive(false);
        }
        else if (PowerCount.P2RoundWinner)
        {
            P2Score++;
            _prButton2.SetActive(true);
            _prButton1.SetActive(false);
            _ohand2.SetActive(true);
            _ohand1.SetActive(false);
            _rgo.SetActive(true);
            _p1Life1.SetActive(false);
        }
        else
        {
            _prButton2.SetActive(false);
            _prButton1.SetActive(true);
            _ohand2.SetActive(false);
            _ohand1.SetActive(true);
            _rgo.SetActive(true);
        }
        if (P1Score == 2)
        {
            _gameOver1.SetActive(true);
        }
        else if (P2Score == 2)
        {
            _gameOver2.SetActive(true);
        }

        for (int k = 0; k < 10; k++)
        {
            for (int i = 0; i < _weather.childCount; i++)
            {
                _weather.GetChild(i).parent = _graveyard1;
            }

            for (int i = 0; i < _melee1.childCount; i++)
            {
                _melee1.GetChild(i).parent = _graveyard1;
            }
            for (int i = 0; i < _mbuff1.childCount; i++)
            {
                _mbuff1.GetChild(i).parent = _graveyard1;
            }
            for (int i = 0; i < _ranged1.childCount; i++)
            {
                _ranged1.GetChild(i).parent = _graveyard1;
            }
            for (int i = 0; i < _rbuff1.childCount; i++)
            {
                _rbuff1.GetChild(i).parent = _graveyard1;
            }
            for (int i = 0; i < _siege1.childCount; i++)
            {
                _siege1.GetChild(i).parent = _graveyard1;
            }
            for (int i = 0; i < _sbuff1.childCount; i++)
            {
                _sbuff1.GetChild(i).parent = _graveyard1;
            }
            //Player 2
            for (int i = 0; i < _melee2.childCount; i++)
            {
                _melee2.GetChild(i).parent = _graveyard2;
            }
            for (int i = 0; i < _mbuff2.childCount; i++)
            {
                _mbuff2.GetChild(i).parent = _graveyard2;
            }
            for (int i = 0; i < _ranged2.childCount; i++)
            {
                _ranged2.GetChild(i).parent = _graveyard2;
            }
            for (int i = 0; i < _rbuff2.childCount; i++)
            {
                _rbuff2.GetChild(i).parent = _graveyard2;
            }
            for (int i = 0; i < _siege2.childCount; i++)
            {
                _siege2.GetChild(i).parent = _graveyard2;
            }
            for (int i = 0; i < _sbuff2.childCount; i++)
            {
                _sbuff2.GetChild(i).parent = _graveyard2;
            }
        }
        Draw2Cards();
    }

    public void Draw2Cards()
    {
        for (int i = 0; i < 2; i++)
        {
            _deck1.GetChild(Random.Range(0, _deck1.childCount - 1)).parent = _hand1;
            _deck2.GetChild(Random.Range(0, _deck2.childCount - 1)).parent = _hand2;
        }
    }
    public void DiscardExtra()
    {
        if (_hand1.childCount > 10)
        {
            for (int i = _hand1.childCount - 1; i > 9; i--)
            {
                _hand1.GetChild(i).parent = _graveyard1;
            }
        }
        if (_hand2.childCount > 10)
        {
            for (int i = _hand2.childCount - 1; i > 9; i--)
            {
                _hand2.GetChild(i).parent = _graveyard2;
            }
        }
    }

}
