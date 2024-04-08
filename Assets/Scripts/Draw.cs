using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject Hand;
    void DrawCard()
    {
        Hand = GameObject.Find("Hand");
    }
}
