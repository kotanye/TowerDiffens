using UnityEngine;

public class DeleteAfter : MonoBehaviour
{

    public void OnClick()
    {
        // Подписываем метод WhatToDoWhenDied на событие
        print("Подписались на событие смерти");
        EventManager.instance.OnEnemyDiedEvent += WhatToDoWhenDied;
    }

    private void WhatToDoWhenDied(GameObject enemy)
    {
        print("Активация события!");
        print($"Умер {enemy.name}");
    }
}
