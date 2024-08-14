using UnityEngine;
using TMPro;

public class TextOrganic : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        
    }

    public TextMeshProUGUI myTextMeshPro; // Asigna el TextMeshPro desde el Inspector

    void Start()
    {
        myTextMeshPro.text = "¡Hola, Mundo!";
    }
}
