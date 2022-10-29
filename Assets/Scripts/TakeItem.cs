using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeItem : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int crystalCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Coin coin))
        {
            crystalCount++;
            _text.text = crystalCount.ToString();
            Destroy(coin.gameObject);
        }
    }
}