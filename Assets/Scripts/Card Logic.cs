using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    //public static GameObject cardToButton;
    public static GameObject cardToButton;
    public GameObject _rgo;
    public GameObject _RButton1;
    public GameObject _RButton2;
    public GameObject _cardToPlay;
    public GameObject _m1button;
    public GameObject _bm1button;
    public GameObject _r1button;
    public GameObject _br1button;
    public GameObject _s1button;
    public GameObject _bs1button;
    public GameObject _m2button;
    public GameObject _bm2button;
    public GameObject _r2button;
    public GameObject _br2button;
    public GameObject _s2button;
    public GameObject _bs2button;
    public Transform _hand1;
    public Transform _hand2;
    public Transform _graveyard1;
    public Transform _graveyard2;
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
    
    // Start is called before the first frame update
    void Start()
    {
        _rgo = GameObject.Find("RGO");
        _hand1 = GameObject.Find("Hand1").transform;
        _hand2 = GameObject.Find("Hand2").transform;
        _RButton1 = GameObject.Find("PassRound1");
        _RButton2 = GameObject.Find("PassRound2");
        _weather = GameObject.Find("WeatherSlot").transform;
        _graveyard1 = GameObject.Find("Graveyard1").transform;
        _graveyard2 = GameObject.Find("Graveyard2").transform;
        _melee1 = GameObject.Find("Melee1").transform;
        _mbuff1 = GameObject.Find("MBuff1").transform;
        _ranged1 = GameObject.Find("Ranged1").transform;
        _rbuff1 = GameObject.Find("RBuff1").transform;
        _siege1 = GameObject.Find("Siege1").transform;
        _sbuff1 = GameObject.Find("SBuff1").transform;
        _melee2 = GameObject.Find("Melee2").transform;
        _mbuff2 = GameObject.Find("MBuff2").transform;
        _ranged2 = GameObject.Find("Ranged2").transform;
        _rbuff2 = GameObject.Find("RBuff2").transform;
        _siege2 = GameObject.Find("Siege2").transform;
        _sbuff2 = GameObject.Find("SBuff2").transform;
        _m1button = GameObject.Find("M1Button");
        _bm1button = GameObject.Find("BM1Button");
        _r1button = GameObject.Find("R1Button");
        _br1button = GameObject.Find("BR1Button");
        _s1button = GameObject.Find("S1Button");
        _bs1button = GameObject.Find("BS1Button");
        _m2button = GameObject.Find("M2Button");
        _bm2button = GameObject.Find("BM2Button");
        _r2button = GameObject.Find("R2Button");
        _br2button = GameObject.Find("BR2Button");
        _s2button = GameObject.Find("S2Button");
        _bs2button = GameObject.Find("BS2Button");
    }

    void Update()
    {
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 10)
        {
            if (_cardToPlay.transform.parent == _weather)
            {
                CardEffects.Blizzard();
            }
        }
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 20)
        {
            if (_cardToPlay.transform.parent == _weather)
            {
                CardEffects.Fog();
            }
        }
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 30)
        {
            if (_cardToPlay.transform.parent == _weather)
            {
                CardEffects.Rain();
            }
        }
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 4)
        {
            if (_cardToPlay.transform.parent == _mbuff1)
            {
                CardEffects.M1Buff();
            }
            else if (_cardToPlay.transform.parent == _mbuff2)
            {
                CardEffects.M2Buff();
            }
            else if (_cardToPlay.transform.parent == _rbuff1)
            {
                CardEffects.R1Buff();
            }
            else if (_cardToPlay.transform.parent == _rbuff2)
            {
                CardEffects.R2Buff();
            }
            else if (_cardToPlay.transform.parent == _sbuff1)
            {
                CardEffects.S1Buff();
            }
            else if (_cardToPlay.transform.parent == _sbuff2)
            {
                CardEffects.S2Buff();
            }
        }
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 0)
        {
            if (_cardToPlay.transform.parent == _weather)
            {
                for (int i = 0; i < _weather.childCount; i++)
                {
                    _weather.GetChild(i).parent = _graveyard1;
                }
            }
        }
    }

    public void PlayCard()
    {
        _m1button.SetActive(false);
        _bm1button.SetActive(false);
        _r1button.SetActive(false);
        _br1button.SetActive(false);
        _s1button.SetActive(false);
        _bs1button.SetActive(false);
        _m2button.SetActive(false);
        _bm2button.SetActive(false);
        _r2button.SetActive(false);
        _br2button.SetActive(false);
        _s2button.SetActive(false);
        _bs2button.SetActive(false);
        cardToButton = _cardToPlay;
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 1)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _melee1;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true);
                _RButton2.SetActive(true);
                }
                
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _melee2;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 2)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _ranged1;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _ranged2;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 3)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _siege1;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _siege2;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 12)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _m1button.SetActive(true);
                _r1button.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _m2button.SetActive(true);
                _r2button.SetActive(true);
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 123)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _m1button.SetActive(true);
                _r1button.SetActive(true);
                _s1button.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _m2button.SetActive(true);
                _r2button.SetActive(true);
                _s2button.SetActive(true);
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 0)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 10)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
                //CardEffects.Blizzard();
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
                //CardEffects.Blizzard();
            } 
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 20)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
                CardEffects.Fog();
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
                CardEffects.Fog();
            }            
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 30)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(false);
                _RButton1.SetActive(false);
                _hand2.gameObject.SetActive(true); 
                _RButton2.SetActive(true);
                }
                CardEffects.Rain();
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                if (_rgo.activeSelf)
                {
                _hand1.gameObject.SetActive(true);
                _RButton1.SetActive(true);
                _hand2.gameObject.SetActive(false); 
                _RButton2.SetActive(false);
                }
                CardEffects.Rain();
            }            
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 4)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _bm1button.SetActive(true);
                _br1button.SetActive(true);
                _bs1button.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _bm2button.SetActive(true);
                _br2button.SetActive(true);
                _bs2button.SetActive(true);
            }
        }
    }
}
