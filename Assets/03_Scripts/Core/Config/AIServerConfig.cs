using UnityEngine;

namespace VStage.Core.Config
{
    /// <summary>
    /// AI server WebSocket connection configuration.
    /// AI 서버 WebSocket 연결 설정을 관리합니다.
    /// </summary>
    [CreateAssetMenu(fileName = "AIServerConfig", menuName = "VStage/Config/AI Server Config")]
    public class AIServerConfig : ScriptableObject
    {
        [Header("WebSocket Endpoints")] [Tooltip("WebSocket URL for audio data transmission")]
        public string audioWebSocketUrl = "ws://221.163.19.142:58026/ws/audio";
        
        [Tooltip("WebSocket URL for trigger signals (gauge_full, etc.)")]
        public string triggerWebSocketUrl = "ws://221.163.19.142:58026/ws/trigger";

        [Header("Connection Settings")]
        [Tooltip("Maximum number of connection retry attempts")]
        [Range(1, 10)]
        public int maxRetryAttempts = 3;

        [Tooltip("Delay between retry attempts in seconds")]
        public float retryDelay = 2f;

        [Tooltip("WebSocket connection timeout in seconds")]
        public float connectionTimeout = 10f;

        [Header("Audio Settings")]
        [Tooltip("Audio sample rate for recording")]
        public int sampleRate = 16000;

        [Tooltip("Maximum recording duration in seconds")]
        public int maxRecordDuration = 10;
    }
}