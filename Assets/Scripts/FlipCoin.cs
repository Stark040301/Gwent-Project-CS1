using System.Security.AccessControl;
using System.Dynamic;
using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlipCoin : MonoBehaviour
{
    Image _frontSide;
    public Sprite[] sides;
    public GameObject _cointoss;
    public GameObject _firstPlayer;
    public GameObject _hand1;
    public GameObject _hand2;
    public GameObject _coin;
    public TMP_Text _firstPlayerInfo;
    public int side;

    void Start()
    {
        _frontSide = GetComponent<Image>();
    }

    void Update()
    {
        //Press space to flip the coin
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(FlipTime(0.00001f, 1.0f));
            _cointoss.SetActive(false);
            StartCoroutine(ActivateFirstPlayer(4.1f));
        }
    }
    IEnumerator FlipTime(float duration, float size)
    {
        //A for statement to determine how many times the coin will flip
        for (float i = 0f; i < UnityEngine.Random.Range(8.0f,11.0f); i++)
        {
            side = Convert.ToInt32(i) % 2;
            while (size > 0.1f)
            {
            size = size - 0.09f;
            transform.localScale = new Vector3(1, size, 1);
            yield return new WaitForSeconds(duration);
            }
        _frontSide.sprite = sides[side];
            while (size < 1)
            {
            size = size + 0.09f;
            transform.localScale = new Vector3(1, size, 1);
            yield return new WaitForSeconds(duration);
            }
        }
    }
    IEnumerator ActivateFirstPlayer(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (side == 0)
        {
            _firstPlayerInfo.SetText("El Jugador 1 juega primero. ¡¡Buena suerte!!\n¡¡Valar Morghulis!!");
        }
        else
        {
            _firstPlayerInfo.SetText("El Jugador 2 juega primero. ¡¡Buena suerte!!\n¡¡Valar Morghulis!!");
        }
        _firstPlayer.SetActive(true);
        yield return new WaitForSeconds(delay);
        _coin.SetActive(false);
        if (side == 0)
        {
            _hand1.SetActive(true);
        }
        else
        {
            
            _hand2.SetActive(true);
        }
    }
}