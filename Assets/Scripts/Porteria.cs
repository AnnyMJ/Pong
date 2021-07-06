using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porteria : MonoBehaviour {
    //detecto si la bola atraviesa la porteria
    void OnTriggerEnter2D(Collider2D bola) {
        //Si es la portería izquierda
        //Cuento el gol y reinicio la bola
        //Si es la portería derecha
        //Cuento el gol y reinicio la bola

        if (bola.name == "Bola") {
            if (this.name == "Izquierda") {
                bola.GetComponent<Bola>().reiniciarBola("Derecha");
            } else if (this.name == "Derecha") {
                bola.GetComponent<Bola>().reiniciarBola("Izquierda");
            }
        }
    }
}
