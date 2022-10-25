using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 initialPosition;
    public Text healthText;

    private void Start()
    {
        initialPosition = transform.position;
        currentHealth = MaxHealth;
        healthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        healthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Debug.Log("Has Muerto...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //transform.position = initialPosition;
            //currentHealth = MaxHealth;
            //healthText.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("¡Te han echo daño!, te queda " + currentHealth + (" de vida."));
        }
    }
}