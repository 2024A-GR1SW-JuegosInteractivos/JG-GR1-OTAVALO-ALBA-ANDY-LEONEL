using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Importa TextMeshPro

public class PersonScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float velocidadRapido = 15f;
    [SerializeField] float velocidadLento = 5f;

    // Contadores para cada tipo de objeto
    private int plasticCollected = 0;
    private int paperCollected = 0;
    private int glassCollected = 0;
    private int organicCollected = 0;

    // Referencias a los textos de UI
    public TextMeshProUGUI plasticText;
    public TextMeshProUGUI paperText;
    public TextMeshProUGUI glassText;
    public TextMeshProUGUI organicText;

    void Start()
    {
        // Inicializa los textos en pantalla
        UpdateUI();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        // Solo permite movimiento en los ejes X e Y
        transform.Translate(moveX, moveY, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rapido")
        {
            Debug.Log("Ir Rapido");
            moveSpeed = velocidadRapido;
        }
        else if (other.tag == "Lento")
        {
            Debug.Log("Ir Lento");
            moveSpeed = velocidadLento;
        }
        else if (other.tag == "Plastic")
        {
            plasticCollected++;
            Destroy(other.gameObject);
            UpdateUI();
        }
        else if (other.tag == "Paper")
        {
            paperCollected++;
            Destroy(other.gameObject);
            UpdateUI();
        }
        else if (other.tag == "Glass")
        {
            glassCollected++;
            Destroy(other.gameObject);
            UpdateUI();
        }
        else if (other.tag == "Organic")
        {
            organicCollected++;
            Destroy(other.gameObject);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        plasticText.text = "Plastic: " + plasticCollected;
        paperText.text = "Paper: " + paperCollected;
        glassText.text = "Glass: " + glassCollected;
        organicText.text = "Organic: " + organicCollected;
    }
}
