using UnityEngine;




public class DestroyWall : MonoBehaviour

{

private void OnCollisionEnter2D(Collision2D collision)

{

if (collision.gameObject.CompareTag("Breakable"))

{

Destroy(collision.gameObject);

}

}

}
