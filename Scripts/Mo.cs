using System.Collections;
using UnityEngine;
using System.Collections;
public class Mo : MonoBehaviour {
// Переменная для координат объекта player
private Transform player;
public GameObject fish;
// Скорость движения врага
public float speed = 1.0f;
// Use this for initialization
void Start () {
player = GameObject.Find("player").transform;
}
// Update is called once per frame
void Update () {
Vector3 delta = player.position - fish.transform.position; //нашливектор нужного направления
delta.Normalize(); // превратили в вектор -модуль которого 1
float moveSpeed = speed * Time.deltaTime; // нормализация плавного движения объекта
fish.transform.position = fish.transform.position - (delta * moveSpeed); // получение нового положения(выглядит как анимациядвижения)
}
}