using UnityEngine;

using TMPro;


public class CoinManager : MonoBehaviour

{

public int coins = 0;

public TextMeshProUGUI coinText;

 
void Start()

{

coinText.text = "Coins: 0";

}


public void AddCoin()

{
    
coins++;
    
coinText.text = "Coins: " + coins;
    
}

}