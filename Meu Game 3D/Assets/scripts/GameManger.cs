using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class GameManger : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource _source;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out _source);
        restantes = FindObjectsOfType<Moeda>().Length;
        hud.text = $"moedas restantes: {restantes}";

    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        _source.PlayOneShot(clipMoeda);
        
        if (restantes <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "parabéns";
            _source.Stop();
            _source.PlayOneShot(clipVitoria);
        }
        

        
    }
    
    
    
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
