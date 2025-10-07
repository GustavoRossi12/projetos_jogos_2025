using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;

    public void AddPontos(int qtd)
    {
        pontos += qtd;

        Debug.Log("pontos: " + pontos);

        if (pontos < 0)
        {
            pontos = 0;
        }
    }

    public void PerderVidas(int qtd)
    {
        vidas -= 1;
        Debug.Log("vidas: " +  vidas);
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<player>().ReiniciarPosicao();

        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("game over");
        }
    }
}
