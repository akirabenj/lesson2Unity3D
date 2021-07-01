using System.Collections;
using UnityEngine;
using System.Collections;
public class EnemyScript : MonoBehaviour {
// Сколько раз нужно попасть во врага, чтобы уничтожить его
public int health = 1;
public GameObject player;
void OnCollisionEnter2D(Collision2D theCollision)
{
//Проверяем коллизию с объектом типа «лазер»
if(theCollision.gameObject.name.Contains("big fish"))
{
health -= 1;
}
if (health <= 0)
{
Destroy (this.gameObject);
Destroy (player.gameObject);
}
}
}