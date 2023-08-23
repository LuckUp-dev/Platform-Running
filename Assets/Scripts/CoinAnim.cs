using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;

    [SerializeField] GameObject _coinSound;
    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(_coinSound);
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
    }
}
