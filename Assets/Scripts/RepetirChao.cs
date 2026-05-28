using UnityEngine;

public class RepetirChao : MonoBehaviour
{
    private GamaController _gameController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameController = FindAnyObjectByType<GamaController>() as GamaController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        MoveChao();
    }
    void MoveChao()
    {
        transform.Translate(Vector3.left * _gameController._ChaoVelocidade * Time.deltaTime);
    }

}

