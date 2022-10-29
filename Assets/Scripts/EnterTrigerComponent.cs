using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigerComponent : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private UnityEvent _action;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>())
        {
            _action?.Invoke();
        }
    }
}
