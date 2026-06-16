using UnityEngine;

public class DeslocamentoBg : MonoBehaviour
{

    // Variaveis
    private Renderer objetoRenderer;
    private Material objetoMaterial;

    private float offset; // deslocamento do material
    private float offsetIncremento; // valor do incremento do deslocamento
    private float offsetVelocidade; // Valor da velocidade do deslocamento

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Vamos acessar o componente  meshRenderer do objeto e o material do mesmo
        objetoRenderer = GetComponent<Renderer>();

        objetoMaterial = objetoRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += offsetIncremento;
        objetoMaterial.SetTextureOffset("_MainTex", new Vector2(offset * offsetVelocidade, 0));
    }
}
