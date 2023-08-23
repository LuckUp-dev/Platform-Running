using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{

    [SerializeField] GameObject _brickEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            playerModifier.HitBarrier();
            Destroy(gameObject);
            Instantiate(_brickEffectPrefab, transform.position, transform.rotation);
        }
    }
}
