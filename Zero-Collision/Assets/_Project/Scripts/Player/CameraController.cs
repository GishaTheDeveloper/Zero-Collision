﻿using UnityEngine;

namespace Gisha.ZeroCollision.Player
{
    [RequireComponent(typeof(Camera))]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float followSpeed = default;
        [SerializeField] private Transform targetToFollow = default;
        [SerializeField] private Vector3 offset = default;

        public Vector3 Offset => offset;

        Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            FollowTarget();
        }

        private void FollowTarget()
        {
            Vector3 oldPos = _transform.position;
            Vector3 newPos = new Vector3(targetToFollow.position.x, _transform.position.y, _transform.position.z) + Offset;
            _transform.position = Vector3.Lerp(oldPos, newPos, followSpeed * Time.deltaTime);
        }
    }
}