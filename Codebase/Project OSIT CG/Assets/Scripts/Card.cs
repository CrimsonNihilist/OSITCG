using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int health, attack, cost;
    public string Name, Description;
    public Card()
    {
        health = 1;
        attack = 0;
        cost = 0;
        Name = "Soldier Guy";
        Description = "Can Be Played";
    }
    public Card(int aHealth, int aAttack, int aCost, string aName, string aDesc)
    {
        health = aHealth;
        attack = aAttack;
        cost = aCost;
        Name = aName;
        Description = aDesc;
    }
    public Card(Card aCard)
    {
        health = aCard.health;
        attack = aCard.attack;
        cost = aCard.cost;
        Name = aCard.Name;
        Description = aCard.Description;
    }
    ~Card()
    {
    }
}
