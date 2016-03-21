using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject jugador;
	private Vector3 relPos;

	// Use this for initialization
	void Start () {
		relPos = transform.position - jugador.transform.position;
	}
	
	// Ejecuta despues de todos los Updates
	void LateUpdate () {
		transform.position = jugador.transform.position + relPos;
	}
}
