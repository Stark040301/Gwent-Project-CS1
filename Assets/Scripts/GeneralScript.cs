using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GwentProject
{
    public class GeneralScript : MonoBehaviour
    {
    
        void Start()
        {
            UnityEngine.Debug.Log("Gato");
            Card _test = new Card();
            _test.setInfo(10, "Norte", "Plata", "cuerpo a cuerpo", "Soldado");
            UnityEngine.Debug.Log(_test.getPower());
            UnityEngine.Debug.Log(_test.getInfo());
        }

    
        void Update()
        {
        
        }
    }

    public class Board
    {

    }

    public class Card
    {
        public void setInfo(int _power, string _faction, string _type, string _attackType, string _name)
        {
           this._power = _power;
            this._faction = _faction;
            this._type = _type;
            this._attackType = _attackType;
            this._name = _name;
        }
        public int getPower()
        {
            return _power;
        }
        public string getInfo()
        {
            return "Nombre: " + _name + " Faccion: " + _faction + " Tipo: " + _type + " Tipo de Ataque: " + _attackType;
        }
        private int _power;
        private string _faction;
        private string _type;
        private string _attackType;
        private string _name;


    }

    public class Player
    {

    }
}
