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

        //Enemigos reciben daño
        ogro.RecibirDaño(50);
        esqueleto.RecibirDaño(90);

        //Crear ítems
        PocionVida pocionVida = new PocionVida("Poción de Vida");
        PocionNivel pocionNivel = new PocionNivel("Poción de Nivel");

        //Usar ítems
        pocionVida.Consumible(ogro);
        pocionNivel.AplicarBuffs(ogro);
    }
}
