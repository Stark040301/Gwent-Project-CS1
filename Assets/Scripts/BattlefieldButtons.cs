using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlefieldButtons : MonoBehaviour
{
    public Transform _row;
    public GameObject _RButton1;
    public GameObject _RButton2;
    public GameObject _rgo;
    public GameObject _hand1;
    public GameObject _hand2;
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

    public void BPlayCard()
    {
        CardLogic.cardToButton.transform.parent = _row;
    }
    public void DeactivateAll()
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
    }

    public void P1ActivateHand()
    {
        if (_rgo.activeSelf)
        {
            _hand1.SetActive(false);
            _RButton1.SetActive(false);
            _hand2.SetActive(true);
            _RButton2.SetActive(true);
        }
    }

    public void P2ActivateHand()
    {
        if (_rgo.activeSelf)
        {
            _hand1.SetActive(true);
            _RButton1.SetActive(true);
            _hand2.SetActive(false);
            _RButton2.SetActive(false);
        }
    } 
}
