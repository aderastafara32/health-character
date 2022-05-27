using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	[SerializeField]
	int _maximumHealth = 100;

	int _currentHealth = 0;

	public void Start()
	{
		_currentHealth = _maximumHealth;

	}

	
	public void Damage(int damageValue)
	{
		_currentHealth -= damageValue;
		if (_currentHealth <= 0)
        {
			Destroy(gameObject);
        }
	
	}
}
