using System;
using _Scripts;
using UnityEngine;
using UnityEngine.UI;

public class ReactJSBridge : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] particlePrefabs;
    [SerializeField] private Button talkToReactButton;

    private void Awake()
    {
        talkToReactButton.onClick.AddListener(TalkToReact);
    }

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

    private int _messagesToReactCount;

    private void TalkToReact()
    {
        _messagesToReactCount++;
        JsMethods.TalkToReact($"Messages from Unity {_messagesToReactCount}");
    }

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