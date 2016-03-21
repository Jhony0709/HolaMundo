using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	int score;
	Rigidbody rb;
	public float velocidad;
	public Text puntuacion;
	public Text ganar;

	public void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		score++;
		actualizarMarcador();
		if(score == 7)
		{
			ganar.text = "GANASTE";
		}
	}

	private void actualizarMarcador()
	{
		puntuacion.text = "Puntuación: " + score;
	}

	public void Awake()
	{
		rb = GetComponent<Rigidbody>();
		score = 0;
		ganar.text = "";
		actualizarMarcador();
	}

	public void FixedUpdate() //Porque tiene que ver con la física
	{
		float movHorizontal = Input.GetAxis("Horizontal");
		float movVertical = Input.GetAxis("Vertical");

		Vector3 mov = new Vector3(movHorizontal, 0, movVertical);
		rb.AddForce(mov*velocidad);
	}
}
