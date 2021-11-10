using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Demo", "This is a demo"));
        cardList.Add(new Card(1, "None", "None"));
        cardList.Add(new Card(2, "None", "None"));
        cardList.Add(new Card(3, "None", "None"));
        cardList.Add(new Card(4, "None", "None"));
        cardList.Add(new Card(5, "None", "None"));
    }
}
