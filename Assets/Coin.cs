using UnityEngine;


public class Coin : MonoBehaviour

{

public AudioClip coinSound;

 

private void OnTriggerEnter2D(Collider2D other)

{

if (other.CompareTag("Player"))

{

AudioSource.PlayClipAtPoint(

coinSound,

transform.position,

20f

);

 

FindObjectOfType<CoinManager>().AddCoin();

 

Destroy(gameObject);

}

}

}
