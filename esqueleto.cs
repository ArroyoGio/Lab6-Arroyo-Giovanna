using UnityEngine;

public class esqueleto : Enemigo, IAtacar, IRecibirDa�o, IDropearItems
{
    #region constructor
    public esqueleto(string nombre, int vida, int nivel)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        vivo = true;
    }
    #endregion

    #region metodos
    public override void HabilidadEspecial()
    {
        Debug.Log(nombre + " lanza su brazo.");
    }
    public void Atacar()
    {
        Debug.Log(nombre + " ataca con sus huesos.");
    }
    public void RecibirDa�o(int da�o)
    {
        vida = vida - da�o;

        if (vida <= 0)
        {
            vivo = false;
            Debug.Log(nombre + " ha muerto.");
        }
        else
        {
            Debug.Log(nombre + " recibi� da�o. Vida: " + vida);
        }
    }
    public void DropearItems()
    {
        Debug.Log(nombre + " dej� caer un objeto.");
    }
    #endregion
}
