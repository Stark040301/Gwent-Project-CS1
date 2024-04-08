using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //I use static for best compatability between scripts.

    void Awake()
    {
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
                                                                         //Neutral Units
        //Hero Units
        cardList.Add(new Card(1, "Jaqen H'ghar", 8, 12, "Un hombre no tiene nombre, y sin embargo, mil nombres. Maestro de sombras y cambiante como el viento, Jaqen H'ghar sirve al Dios de Muchos Rostros, equilibrando la balanza de la vida y la muerte con una precisión inquietante.","Héroe", "Elimina la carta con más poder del campo. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Jaqen H'ghar"), Resources.Load<Sprite>("Sword and Bow"), Resources.Load<Sprite>("E3")));
        cardList.Add(new Card(2, "Oberyn Martell", 11, 1, "Conocido en todo Poniente como la Víbora Roja, Oberyn Martell es un guerrero feroz.Su presencia en el campo de batalla es tanto un espectáculo como una sentencia de muerte, manchada por el toque mortal de su lanza envenenada.", "Héroe", "Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Oberyn Martell"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(3, "El Perro", 11, 1, "Sandor Clegane, conocido como 'El Perro', es la encarnación de la ferocidad y el conflicto interno.Su habilidad en combate es legendaria, igualada solo por su profundo desprecio hacia su hermano, Gregor 'La Montaña' Clegane", "Héroe", "Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("El Perro"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(4, "Varys", 5, 1, "Varys, conocido como 'La Araña', es el Consejero de los Rumores del Trono de Hierro. Su red de espías se extiende por todo el mundo conocido, y su influencia y sus conspiraciones lo convierten en uno de los jugadores más peligrosos en el juego de tronos.", "Héroe", "Roba una carta del mazo. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Varys"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("E5")));
        cardList.Add(new Card(5, "Petyr Baelish", 5, 1, "Petyr Baelish, conocido como 'Meñique', es Consejero de la Moneda del Trono de Hierro. Es el epítome del ascenso a través de la astucia y la manipulación. Desde sus humildes comienzos hasta convertirse en uno de los consejeros más influyentes del reino, su ambición no conoce límites.", "Héroe", "Juega una carta de aumento en la fila correspondiente. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Petyr Baelish"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("E1")));
        //Silver Units
        cardList.Add(new Card(6, "Gorrión Supremo", 0, 1, "Ninguna", "Plata", "Justicia Divina: Rogamos misericordia al Padre y al Guerrero para que nos den su bendición y hagan de este combate una batalla justa, igualando el poder de todas las unidades del campo.", Resources.Load<Sprite>("High Sparrow"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("E8")));
        cardList.Add(new Card(7, "Bronn", 7, 12, "Ninguna", "Plata", "Esta carta no tiene ninguna abilidad especial.", Resources.Load<Sprite>("Bronn"), Resources.Load<Sprite>("Sword and Bow"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(8, "Brienne of Tarth", 8, 1, "Ninguna", "Plata", "Esta carta no tiene ninguna abilidad especial.", Resources.Load<Sprite>("Brienne"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(9, "Beric Dondarrion", 5, 1, "Ninguna", "Plata", "Elimina la carta con menor poder del enemigo", Resources.Load<Sprite>("Beric"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("E4")));
        cardList.Add(new Card(10, "Thoros de Myr", 7, 1, "Ninguna", "Plata", "Esta carta no tiene ninguna abilidad especial.", Resources.Load<Sprite>("Thoros"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("Empty Image")));
        //Special Cards
        cardList.Add(new Card(11, "Ventisca", 0, 0, "Ninguna", "Clima", "Reduce a 1 el poder de todas las unidades de Combate Cercano de ambos jugadores.", Resources.Load<Sprite>("Blizzard"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Cold")));
        cardList.Add(new Card(12, "Niebla Cegadora", 0, 0, "Ninguna", "Clima", "Reduce a 1 el poder de todas las unidades de Combate a Distancia de ambos jugadores.", Resources.Load<Sprite>("Fog"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("FogIcon")));
        cardList.Add(new Card(13, "Tempestad", 0, 0, "Ninguna", "Clima", "Reduce a 1 el poder de todas las unidades de Asedio de ambos jugadores.", Resources.Load<Sprite>("Storm"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Rain")));
        cardList.Add(new Card(14, "Despejado", 0, 0, "Ninguna", "Clima", "Elimina todas las cartas tipo Clima del campo.", Resources.Load<Sprite>("Clear"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Clear Skies")));
        cardList.Add(new Card(15, "Cuerno Legendario", 0, 4, "Ninguna", "Aumento", "Duplica el poder de todas las unidades de la fila. Sólo se puede jugar una carta de aumento por ronda.", Resources.Load<Sprite>("Buff"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Horn")));
        cardList.Add(new Card(16, "Bufón", 0, 123, "Ninguna", "Señuelo", "Intercambia esta carta por cualquier unidad en tu lado del campo para regresarla a la mano.", Resources.Load<Sprite>("Jester"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Decoy")));
                                                                          //The North
        //Leader
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        //Hero Units
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        //Silver Units
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
                                                                          //The Crown
        //Leader
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        //Hero Units
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        //Silver Units
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
    }
}
