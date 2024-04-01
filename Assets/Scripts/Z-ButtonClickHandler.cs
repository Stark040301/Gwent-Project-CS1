using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject _info;
   public void OnButtonRightClick()
    {
        Debug.Log("Button right-clicked!");
        _info.SetActive(_info.activeSelf);
    }

   public void OnButtonLeftClick()
    {
        Debug.Log("Button left-clicked!");
    }
}
