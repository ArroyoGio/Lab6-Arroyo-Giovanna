using UnityEngine;


#region interfaces
public interface IAtacar
{
    public void Atacar();
}

public interface IRecibirDaño
{
    public void RecibirDaño(int daño);
}
//caida de objetos
public interface IDropearItems
{
    public void DropearItems();
}
#endregion


public abstract class Enemigo : MonoBehaviour
{
    //atributo de la clase padre
    #region atributos
    protected string nombre;
    protected int vida;
    protected int nivel;
    protected bool vivo;
    #endregion

    //aplico sobrecarga
    #region constructor
    public Enemigo()
    {
        nombre = "SinNombre";
        vida = 100;
        nivel = 1;
        vivo = true;
    }

    public Enemigo(string nombre, int vida, int nivel, bool vivo)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.nivel = nivel;
        this.vivo = vivo;
    }
    #endregion

    #region getters y setters

    
    //metodo especial para aplicar a clases hijas
    public abstract void HabilidadEspecial();
    
    //Métodos comunes
    public string GetNombre()
    {
        return nombre;
    }

    public int GetVida()
    {
        return vida;
    }

    public int GetNivel()
    {
        return nivel;
    }

    public bool EstaVivo()
    {
        return vivo;
    }

    public void SetVida(int nuevaVida)
    {
        vida = nuevaVida;
    }

    public void SetNivel(int nuevoNivel)
    {
        nivel = nuevoNivel;
    }
    #endregion
}
