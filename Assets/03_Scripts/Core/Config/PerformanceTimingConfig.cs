using UnityEngine;

namespace VStage.Core.Config
{
    /// <summary>
    /// Performance timeline event timing configuration.
    /// 퍼포먼스 타임라인 이벤트 타이밍 설정을 관리합니다.
    /// </summary>
    [CreateAssetMenu(fileName = "PerformanceTimingConfig", menuName = "VStage/Config/Performance Timing Config")]
    public class PerformanceTimingConfig : ScriptableObject
    {
        [Header("Timeline Events")]
        [Tooltip("Seconds after performance start to trigger AI analysis request (gauge_full)")]
        public float aiAnalysisTriggerTime = 33f;
        
        [Tooltip("Seconds after performance start to display AI keywords to audience")]
        public float aiDisplayTime = 34f;

        [Tooltip("Interval between sequential keyword reveals in seconds")]
        public float keywordRevealInterval = 0.5f;

        [Header("Recording")]
        [Tooltip("Maximum duration for microphone recording in seconds")]
        public float micRecordingMaxDuration = 10f;

        [Tooltip("Duration of the recording end effect animation in seconds")]
        public float recordEndEffectDuration = 2f;
    }
}