using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour {
    public int Gold;
	// Use this for initialization
	void Start () {
        Gold = 10;
        transform.GetChild(0).GetComponent<Text>().text = Gold.ToString();
    }
	public bool CostCheck(int CardCost)
    {
        if (CardCost <= Gold)
        {
            Gold -= CardCost;
            transform.GetChild(0).GetComponent<Text>().text = Gold.ToString();
            return true;
        }
        else
            return false;
    } 
}
