using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInfoPlug : MonoBehaviour {
    public int health, attack, cost;
    public string Name, Description;
    Transform NameText, DescriptionText, Attack, Health, Cost;
	// Use this for initialization
	public void Makeit () {
        NameText = this.transform.GetChild(0);
        DescriptionText = this.transform.GetChild(2);
        Attack = this.transform.GetChild(3);
        Health = this.transform.GetChild(4);
        Cost = this.transform.GetChild(5);
        if (Name != null)
        {
            NameText.GetComponent<Text>().text = Name;
        }
        if (Description != null)
        {
            DescriptionText.GetComponent<Text>().text = Description;
        }
        if (cost >= 0)
        {
            Cost.GetComponent<Text>().text = cost.ToString();
        }
        if (health != 0)
        {
            Health.GetComponent<Text>().text = health.ToString();
            Attack.GetComponent<Text>().text = attack.ToString();
        }
        else
        {
            Health.GetComponent<Text>().text = null;
            Attack.GetComponent<Text>().text = null;
        }
    }
}
