using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;
    public delegate void OnEnemyDiedDelegate(GameObject enemy);

    public event OnEnemyDiedDelegate OnEnemyDiedEvent;

    private void Awake()
    {
        instance = this;
    }

    // Вызываем метод когда враг умирает
    public void OnEnemyDied(GameObject enemy)
    {
        OnEnemyDiedEvent?.Invoke(enemy);
    }
}
