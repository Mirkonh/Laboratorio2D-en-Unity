using UnityEngine;


public class WinZone : MonoBehaviour

{

public GameObject winPanel;


private void OnTriggerEnter2D(Collider2D other)

{

Debug.Log("Victoria activada");
 

if (other.CompareTag("Player"))

{

winPanel.SetActive(true);

Time.timeScale = 0f;

}

}

}