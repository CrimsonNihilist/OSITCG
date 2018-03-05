using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Deck : MonoBehaviour
{
    List<Card> PlayerDeck;
    Card GCard;
    // Use this for initialization
    void Start()
    {
        PlayerDeck = new List<Card>();
            for (int x = 1; x < 7; x++)
            {
                GCard = new Card();
                GCard.Name = "Soldier Guy";
                GCard.Description = "Buddy boy can be played";
                GCard.health = x;
                GCard.attack = x;
                GCard.cost = x;
                PlayerDeck.Add(GCard);
                Debug.Log("Hey the" + x + "card's health is" + PlayerDeck[x - 1].health);
            }
    }
    void draw()
    {
        Instantiate.
    }
    // Update is called once per frame
    void Update()
    {

    }
}