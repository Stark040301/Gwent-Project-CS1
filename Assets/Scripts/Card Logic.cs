using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    //public static GameObject cardToButton;
    public static GameObject cardToButton;
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
    void Awake()
    {
        _hand1 = GameObject.Find("Hand1").transform;
        _hand2 = GameObject.Find("Hand2").transform;
        _weather = GameObject.Find("WeatherSlot").transform;
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

    // Update is called once per frame
    /*void Update()
    {
    }*/

    public void PlayCard()
    {
        cardToButton = _cardToPlay;
        if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 1)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _melee1;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _melee2;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 2)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _ranged1;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _ranged2;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 3)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _siege1;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _siege2;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
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
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
            }
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 10)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
            }        
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 20)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
            }            
        }
        else if (_cardToPlay.GetComponent<DisplayCard>().cardAttackType == 30)
        {
            if (_cardToPlay.transform.parent == _hand1)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(false);
                _hand2.gameObject.SetActive(true);
            }
            else if (_cardToPlay.transform.parent == _hand2)
            {
                _cardToPlay.transform.parent = _weather;
                _hand1.gameObject.SetActive(true);
                _hand2.gameObject.SetActive(false);
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
