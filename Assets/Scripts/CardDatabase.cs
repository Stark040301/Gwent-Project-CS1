using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //I use static for best compatability between scripts.

    void Awake()
    {
        cardList.Add(new Card(0, "Ninguno", 0, 0, "Ninguna", "Ninguno", "Ninguno", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(1, "Jaqen H'ghar", 8, 12, "Un hombre no tiene nombre, y sin embargo, mil nombres. Maestro de sombras y cambiante como el viento, Jaqen H'ghar sirve al Dios de Muchos Rostros, equilibrando la balanza de la vida y la muerte con una precisión inquietante.","Héroe", "Elimina la carta con más poder del campo. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(2, "Oberyn Martell", 11, 1, "Conocido en todo Poniente como la Víbora Roja, Oberyn Martell es un guerrero feroz.Su presencia en el campo de batalla es tanto un espectáculo como una sentencia de muerte, manchada por el toque mortal de su lanza envenenada.", "Héroe", "Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Jaqen H'ghar"), Resources.Load<Sprite>("Sword and Bow"), Resources.Load<Sprite>("E3")));
        cardList.Add(new Card(3, "El Perro", 11, 1, "Sandor Clegane, conocido como 'El Perro', es la encarnación de la ferocidad y el conflicto interno.Su habilidad en combate es legendaria, igualada solo por su profundo desprecio hacia su hermano, Gregor 'La Montaña' Clegane", "Héroe", "Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("El Perro"), Resources.Load<Sprite>("Sword"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(4, "Varys", 5, 1, "Varys, conocido como 'La Araña', es el Consejero de los Rumores del Trono de Hierro. Su red de espías se extiende por todo el mundo conocido, y su influencia y sus conspiraciones lo convierten en uno de los jugadores más peligrosos en el juego de tronos.", "Héroe", "Roba una carta del mazo. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
        cardList.Add(new Card(5, "Petyr Baelish", 6, 1, "Petyr Baelish, conocido como 'Meñique', es Consejero de la Moneda del Trono de Hierro. Es el epítome del ascenso a través de la astucia y la manipulación. Desde sus humildes comienzos hasta convertirse en uno de los consejeros más influyentes del reino, su ambición no conoce límites.", "Héroe", "Juega una carta de aumento en la fila correspondiente. Esta carta no es afectada por efectos de ninguna otra carta", Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image"), Resources.Load<Sprite>("Empty Image")));
    }
}
