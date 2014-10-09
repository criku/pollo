using UnityEngine;
using System.Collections;

public class gemaScripts : MonoBehaviour {
	public string nivel = "Nivel 03";
	void OnTriggerEnter(Collision2D other){
		if (other.transform.tag == "Player")
Application.LoadLevel (nivel);


						
}
}