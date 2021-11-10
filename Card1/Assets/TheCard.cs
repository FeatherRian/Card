using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TheCard : MonoBehaviour
{
    public static Card theCard;
    public int theId;
    public int id;
    public string cardName;
    public string cardDescription;
    public Text nameText;
    public Text descriptionText;
    void Start()
    {
        theCard = CardDataBase.cardList[theId];
    }

    // Update is called once per frame
    void Update()
    {
        id = theCard.id;
        cardName = theCard.cardName;
        cardDescription = theCard.cardDescription;

        nameText.text = "" + cardName;
        descriptionText.text = " " + cardDescription;
    }
}
