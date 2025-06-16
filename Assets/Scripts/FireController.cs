using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class FireController : MonoBehaviour
{
    private ParticleSystem ps;
    private ParticleSystem.MainModule main;

    [Header("Fire Settings")]
    [Range(0.1f, 5f)] public float fireSize = 1f;
    [Range(0.1f, 5f)] public float fireSpeed = 1f;
    [Range(0.1f, 3f)] public float fireLifetime = 1f;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        main = ps.main;
        ApplySettings();
    }

    void Update()
    {
        ApplySettings(); 
    }

    void ApplySettings()
    {
        main.startSize = fireSize;
        main.startSpeed = fireSpeed;
        main.startLifetime = fireLifetime;
    }
}
