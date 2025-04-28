using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Ogro ogro = new Ogro("Ogro", 120, 2, true);
        esqueleto esqueleto = new esqueleto("Esqueleto Roto", 80, 1);

        //Mostrar habilidades especiales
        ogro.HabilidadEspecial();
        esqueleto.HabilidadEspecial();

        //Atacar
        ogro.Atacar();
        esqueleto.Atacar();

        //Enemigos reciben da�o
        ogro.RecibirDa�o(50);
        esqueleto.RecibirDa�o(90);

        //Crear �tems
        PocionVida pocionVida = new PocionVida("Poci�n de Vida");
        PocionNivel pocionNivel = new PocionNivel("Poci�n de Nivel");

        //Usar �tems
        pocionVida.Consumible(ogro);
        pocionNivel.AplicarBuffs(ogro);
    }
}
