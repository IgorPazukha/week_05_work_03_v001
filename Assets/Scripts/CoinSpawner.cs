using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private bool _isWork;
    [SerializeField] private Coin _coin;

    private Transform _position;

    private void Awake()
    {
        _position = GetComponent<Transform>();
    }
    private void Start()
    {
        StartCoroutine(CreationCoins());
    }

    private IEnumerator CreationCoins()
    {
        float waitSecond = 2;
        var waitTime = new WaitForSeconds(waitSecond);

        while(_isWork)
        {
            Instantiate(_coin, new Vector2(_position.position.x, _position.position.y) , Quaternion.identity);

            yield return waitTime;
        }
    }
}