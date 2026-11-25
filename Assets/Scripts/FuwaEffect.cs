using System.Collections;
using UnityEngine;

public class FuwaEffect : MonoBehaviour
{
    [SerializeField] private float _effectDuration = 1f;
    
    [SerializeField] private float _slowGravityScale = 0.5f;
    
    [SerializeField] private float _lightMass = 0.1f;
    
    private Rigidbody2D _rb;
    
    private float _defaultMass;
    
    private float _defaultGravityScale;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _defaultMass = _rb.mass;
        _defaultGravityScale = _rb.gravityScale;
    }

    public void ApplyFuwaEffect()
    {
        _rb.mass = _lightMass;
        _rb.gravityScale = _slowGravityScale;
        StartCoroutine(WaitForEffectEnd());

    }
    private IEnumerator WaitForEffectEnd()
    {
        yield return new WaitForSeconds(_effectDuration);
        _rb.mass = _defaultMass;
        _rb.gravityScale = _defaultGravityScale;
    }
}
