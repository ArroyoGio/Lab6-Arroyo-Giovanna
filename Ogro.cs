using UnityEngine;

public class Ogro : Enemigo, IAtacar, IRecibirDa�o, IDropearItems
{
    //constructor
    public Ogro(string nombre, int vida, int nivel, bool vivo) : base(nombre, vida, nivel, vivo) 
    {
        
    }

    //metodo abstracto creado en la clase padre
    public override void HabilidadEspecial()
    {
        Debug.Log(nombre + " usa golpe de lodo");
    }

    #region metodos
    public void Atacar()
    {
        Debug.Log(nombre + " ataca con fuerza");
    }
    public void RecibirDa�o(int da�o)
    {
        vida = vida - da�o;
        Debug.Log(nombre + " recibi� " + da�o + " de da�o.");

        if (vida <= 0)
        {
            vivo = false;
            Debug.Log(nombre + " ha muerto.");
            DropearItems();
        }
    }

    public void DropearItems()
    {
        Debug.Log(nombre + " ha dejado caer sus items :o");
    }
    #endregion
}
