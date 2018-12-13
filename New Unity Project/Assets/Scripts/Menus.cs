using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour {

	public GameObject PanelPrincipal;
	public GameObject PanelSecundario;
	public GameObject PanelTerceario;
	public GameObject PanelCuarto;
	
	// Use this for initialization
	public void Start () {
		PanelTerceario.SetActive(false);	
		PanelCuarto.SetActive(false);
	}

	public void Maestro(){
		PanelSecundario.SetActive(false);
		PanelTerceario.SetActive(true);	
	}

	public void Materia(){
		PanelTerceario.SetActive(false);
		PanelCuarto.SetActive(true);
	}

	public void Horario(){
		Application.Quit();
	}
}
