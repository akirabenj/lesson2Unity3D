using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {
// Update is called once per frame
    void Update () {
    // Поворот героя к мышке
        Rotation();
    }
    // Поворот героя к мышке
    void Rotation() {
        // Показываем игроку, где мышка
        Vector3 worldPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(worldPos);
        // Сохраняем координаты указателя мыши
        float dx = this.transform.position.x - worldPos.x;
        float dy = this.transform.position.y - worldPos.y;
        // Вычисляем угол между объектами «Корабль» и «Указатель»
        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        // Трансформируем угол в вектор
        Quaternion rot = Quaternion.Euler(new Vector3(0, 0, angle));
        // Изменяем поворот героя
        this.transform.rotation = rot;
    }
}