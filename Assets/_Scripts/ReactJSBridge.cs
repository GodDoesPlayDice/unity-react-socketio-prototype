using UnityEngine;

public class ReactJSBridge : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] particlePrefabs;

    private int ParticlesIndex
    {
        set
        {
            if (value >= particlePrefabs.Length)
                _particlesIndex = 0;
            else
                _particlesIndex++;
        }
        get => _particlesIndex;
    }
    private int _particlesIndex;
    private ParticleSystem _spawnedParticle;

    public void ShowVFX()
    {
        if (_spawnedParticle != null)
            Destroy(_spawnedParticle.gameObject);
        _spawnedParticle = Instantiate(particlePrefabs[ParticlesIndex]);
        ParticlesIndex++;
        if (_spawnedParticle != null)
            Destroy(_spawnedParticle.gameObject, 1.5f);
    }
    
    
}