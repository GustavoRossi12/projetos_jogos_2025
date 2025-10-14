using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;
    public TextMeshProUGUI textPontos;

    public void AddPontos(int qtd)
    {
        pontos += qtd;

        if (pontos < 0)
        {
            pontos = 0;
        }

        textPontos.text = "pontos: " + pontos;
        Debug.Log("pontos: " + pontos);
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
