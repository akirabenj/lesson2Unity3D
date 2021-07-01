using System.Collections;
using UnityEngine;
using System.Collections;
public class MoveTowardsPlayer : MonoBehaviour {
// Переменная для координат объекта player
private Transform player;
// Скорость движения врага
public float speed = 1.0f;
// Use this for initialization
void Start () {
player = GameObject.Find("player").transform;
}
// Update is called once per frame
void Update () {
Vector3 delta = player.position - transform.position; //нашли вектор нужного направления
delta.Normalize(); // превратили в вектор -модуль которого 1
float moveSpeed = speed * Time.deltaTime; // нормализация плавного движения объекта
transform.position = transform.position + (delta * moveSpeed); //получение нового положения(выглядит как анимация движения)
}
}