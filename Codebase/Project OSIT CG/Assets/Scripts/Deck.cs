using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Deck : MonoBehaviour
{
    List<Card> PlayerDeck,ShuffleDeck;
    Card GCard;
    public GameObject CardTemplate;
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
    public void draw()
    {

        if (PlayerDeck[0] != null)
        {
            Transform PHand;
            PHand = GameObject.Find("hand").transform;
            CardInfoPlug TempInfo = CardTemplate.GetComponent<CardInfoPlug>();
            TempInfo.health = PlayerDeck[0].health;
            TempInfo.attack = PlayerDeck[0].attack;
            TempInfo.cost = PlayerDeck[0].cost;
            TempInfo.Description = PlayerDeck[0].Description;
            TempInfo.Name = PlayerDeck[0].Name;
            TempInfo.Makeit();
            Instantiate(CardTemplate, PHand);
            PlayerDeck.RemoveAt(0);
        }
    }
    public void Shuffle()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            // generate a random number between the decks minimum and maximum
            int R1 = 
            //store two cards, based on that random number
            Card temp = new Card(deck[i].getvalue(), deck[i].getsuit());
            Card temp2 = new Card(deck[R1].getvalue(), deck[R1].getsuit());
            //swap them.
            deck[i] = temp2;
            deck[R1] = temp;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}