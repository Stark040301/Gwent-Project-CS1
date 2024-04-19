using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PowerCount : MonoBehaviour
{
    public static bool P1RoundWinner;
    public static bool P2RoundWinner;
    public int Player1Power;
    public int Player2Power;

    public TMP_Text CardsinHand1Text;
    public TMP_Text CardsinHand2Text;
    public TMP_Text Player1PowerText;
    public TMP_Text Player2PowerText;
    public TMP_Text m1totalPowerText;
    public TMP_Text r1totalPowerText;
    public TMP_Text s1totalPowerText;
    public TMP_Text m2totalPowerText;
    public TMP_Text r2totalPowerText;
    public TMP_Text s2totalPowerText;    

    public Transform _hand1;
    public Transform _hand2;
    public Transform _melee1;
    public Transform _ranged1;
    public Transform _siege1;
    public Transform _melee2;
    public Transform _ranged2;
    public Transform _siege2;
    void Update()
    {
        RowPowerCount();
    }

    public void RowPowerCount()
    {
        int m1totalPower = 0;
        int r1totalPower = 0;
        int s1totalPower = 0;
        int m2totalPower = 0;
        int r2totalPower = 0;
        int s2totalPower = 0;
        for (int i = 0; i < _melee1.childCount; i++)
        {
            m1totalPower += _melee1.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }

        for (int i = 0; i < _ranged1.childCount; i++)
        {
            r1totalPower += _ranged1.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }

        for (int i = 0; i < _siege1.childCount; i++)
        {
            s1totalPower += _siege1.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }

        for (int i = 0; i < _melee2.childCount; i++)
        {
            m2totalPower += _melee2.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }

        for (int i = 0; i < _ranged2.childCount; i++)
        {
            r2totalPower += _ranged2.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }
        
        for (int i = 0; i < _siege2.childCount; i++)
        {
            s2totalPower += _siege2.GetChild(i).gameObject.GetComponent<DisplayCard>().cardPower;
        }
        Debug.Log("M1 Power: " + m1totalPower);
        Debug.Log("R1 Power: " + r1totalPower);
        Debug.Log("S1 Power: " + s1totalPower);
        Debug.Log("M2 Power: " + m2totalPower);
        Debug.Log("R2 Power: " + r2totalPower);
        Debug.Log("S2 Power: " + s2totalPower);

        Player1Power = m1totalPower + r1totalPower + s1totalPower;
        Player2Power = m2totalPower + r2totalPower + s2totalPower;
        P1RoundWinner = Player1Power > Player2Power;
        P2RoundWinner = Player2Power > Player1Power;
        Debug.Log("P1 Power: " + Player1Power);
        Debug.Log("P2 Power: " + Player2Power);
        
        CardsinHand1Text.text = "" + _hand1.childCount;
        CardsinHand2Text.text = "" + _hand2.childCount;
        Player1PowerText.text = "" + Player1Power;
        Player2PowerText.text = "" + Player2Power;
        m1totalPowerText.text = "" + m1totalPower;
        r1totalPowerText.text = "" + r1totalPower;
        s1totalPowerText.text = "" + s1totalPower;
        m2totalPowerText.text = "" + m2totalPower;
        r2totalPowerText.text = "" + r2totalPower;
        s2totalPowerText.text = "" + s2totalPower;
        
    }

}
