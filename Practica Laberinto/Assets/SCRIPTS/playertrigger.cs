using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertrigger : MonoBehaviour
{
    private string PlayerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerExit(other.gameObject);
        }
    }

    public virtual void OnPlayerExit(GameObject playerobjet)
    {
    }

    public virtual void OnPlayerEnter(GameObject playerobjet)
    {
    }
}