using UnityEngine;

namespace VStage.Core.Config
{
    /// <summary>
    /// Light stick emission behavior configuration.
    /// 라이트스틱 발광 동작 설정을 관리합니다.
    /// </summary>
    [CreateAssetMenu(fileName = "EmissionConfig", menuName = "VStage/Config/Emission Config")]
    public class EmissionConfig : ScriptableObject
    {
        [Header("Velocity-based Emission")] [Tooltip("Velocity threshold (m/s) for maximum brightness")]
        public float maxSpeed = 1f;
        
        [Tooltip("Emission intensity multiplier at maximum speed")]
        [Range(0f, 10f)]
        public float maxIntensity = 4f;

        [Tooltip("Base emission color (will be multiplied by intensity)")]
        public Color baseEmissionColor = Color.cyan;

        [Header("Global Emission")]
        [Tooltip("Global emission intensity for scene-wide effects")]
        [Range(0f, 5f)]
        public float globalIntensity = 1f;
    }
}