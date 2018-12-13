using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour {

	public GameObject PanelSecundario;
	public GameObject Panel1;
	public GameObject Panel2;
	public GameObject Panel3;
	public GameObject Panel4;
	public GameObject Panel5;
	public GameObject Panel6;
	public GameObject Panel7;
	public GameObject Panel8;
	
	// Use this for initialization
	public void Start () {
		Panel1.SetActive(false);
	}
	public void Maestro1(){
		PanelSecundario.SetActive(false);
		Panel1.SetActive(true);	
	}
	public void Maestro2(){
		PanelSecundario.SetActive(false);
		Panel2.SetActive(true);	
	}
	public void Maestro3(){
		PanelSecundario.SetActive(false);
		Panel3.SetActive(true);	
	}
	public void Maestro4(){
		PanelSecundario.SetActive(false);
		Panel4.SetActive(true);	
	}
	public void Maestro5(){
		PanelSecundario.SetActive(false);
		Panel5.SetActive(true);	
	}
	public void Maestro6(){
		PanelSecundario.SetActive(false);
		Panel6.SetActive(true);	
	}
	public void Maestro7(){
		PanelSecundario.SetActive(false);
		Panel7.SetActive(true);	
	}
	public void Maestro8(){
		PanelSecundario.SetActive(false);
		Panel8.SetActive(true);	
	}
	public void Salir(){
		Application.Quit();
	}

	public void Return(){
		Panel1.SetActive(false);
		Panel2.SetActive(false);
		Panel3.SetActive(false);
		Panel4.SetActive(false);
		Panel5.SetActive(false);
		Panel6.SetActive(false);
		Panel7.SetActive(false);
		Panel8.SetActive(false);
		PanelSecundario.SetActive(true);
	}
}
