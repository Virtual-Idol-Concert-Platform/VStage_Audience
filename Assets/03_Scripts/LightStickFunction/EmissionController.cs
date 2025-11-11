using UnityEngine;
using VStage.Core.Config;
using VStage.Core.Constants;

[RequireComponent(typeof(Renderer))]
public class EmissionController : MonoBehaviour
{
    [Header("속도 추적")]
    [Tooltip("VelocityEstimator가 붙어 있는 오브젝트 참조")]
    public VelocityEstimator velocityEstimator;
    
    [Header("Configuration")]
    [SerializeField] private EmissionConfig emissionConfig;

    Material _mat;

    void Awake()
    {
        // Renderer에서 인스턴스화된 머티리얼 가져오기
        _mat = GetComponent<Renderer>().material;
        // 초기 Emission 끄기
        // _mat.SetColor("_EmissionColor", Color.black);
        // _mat.DisableKeyword("_EMISSION");
    }

    void Update()
    {
        if (velocityEstimator == null) return;
        
        // 1) 추정 속도 가져오기
        float speed = velocityEstimator.GetVelocityEstimate().magnitude;

        // 2) 0~1 정규화
        float t = Mathf.Clamp01(speed / emissionConfig.maxSpeed);

        // 3) Emission 강도 계산
        float intensity = t * emissionConfig.maxIntensity;
        Color emitCol = emissionConfig.baseEmissionColor * intensity;

        _mat.SetColor(AnimationConstants.SHADER_EMISSION_COLOR, emitCol);
        if (intensity > 0f) _mat.EnableKeyword(AnimationConstants.SHADER_EMISSION_KEYWORD);
        else                _mat.DisableKeyword(AnimationConstants.SHADER_EMISSION_KEYWORD);
    }
}