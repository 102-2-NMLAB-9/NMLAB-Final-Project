using UnityEngine;
using System.Collections;

public class BigBang : MonoBehaviour
{
	string[] undelete = new string[] {"Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"};

	void OnParticleCollision(GameObject other) {
		Debug.Log (other.gameObject.name);
		Debug.Log (this.gameObject.name);

		bool check = true;
		for(int j=0; j<5; ++j) {
			if (other.gameObject.name == undelete[j]) {
				check = false;
			}
		}
		if (check) Destroy (other.gameObject);
	}
}