using UnityEngine;
using System.Collections;

public class HP_Bar : MonoBehaviour {
	public int maxHealth = 100;
	public int currentHealth = 100;

	public float healthBarLength;

	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
		adjustCurrentHealth (0);
	}

	void OnGUI() {
		GUI.Box(new Rect (10,10, healthBarLength, 20), currentHealth + "/" + maxHealth);
	}
	public void adjustCurrentHealth(int adj) {
		currentHealth += adj;  //add to current health value of adj. ex-heal +20, add 20 to current health, or -20 if damage is taken

		if (currentHealth < 1)
			currentHealth = 0;
		if (currentHealth > maxHealth)
			currentHealth = maxHealth;
		if (maxHealth < 1)
			maxHealth = 1;

		healthBarLength = (Screen.width / 2) * (currentHealth / (float)maxHealth); //bar length
	}
}
