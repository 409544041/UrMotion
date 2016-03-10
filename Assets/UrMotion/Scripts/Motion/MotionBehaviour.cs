using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UrMotion
{
	public abstract class MotionBehaviourBase : MonoBehaviour
	{
		public abstract float FrameRate { get; set; }
		public abstract bool IsComplete { get; }
		public event Callback OnComplete;

		protected virtual void Reset()
		{
			OnComplete = null;
		}

		protected virtual void NotifyComplete()
		{
			if (OnComplete != null) {
				var callback = OnComplete;
				OnComplete = null;
				callback();
			}
		}
	}
	public abstract class MotionBehaviour<V> : MotionBehaviourBase
	{
		public static T Get<T>(GameObject g) where T : MotionBehaviour<V>
		{
			var motion = g.GetComponent<T>() ?? g.AddComponent<T>();
			motion.Reset();
			motion.enabled = true;
			return motion;
		}

		protected float elapsedTime;
		protected LinkedList<IEnumerator<V>> velocities;
		protected IEnumerator<V> valueEnumerator;

		protected abstract V value {
			get;
			set;
		}

		public float ElapsedTime {
			get {
				return elapsedTime;
			}
		}

		public IEnumerator<V> ValueEnumerator {
			get {
				return valueEnumerator ?? (valueEnumerator = GetValueEnumerator());
			}
		}

		override public float FrameRate {
			get;
			set;
		}

		override public bool IsComplete {
			get {
				return velocities.First == null;
			}
		}

		public MotionBehaviour()
		{
			velocities = new LinkedList<IEnumerator<V>>();
			FrameRate = Source.DefaultFrameRate;
		}

		public void Add(IEnumerator<V> v)
		{
			velocities.AddLast(v);
		}

		public void Wrap(Func<IEnumerator<V>, IEnumerator<V>> f)
		{
			var last = velocities.Last;
			if (last != null) {
				last.Value = f(last.Value);
			}
		}

		public void Compose(Func<IEnumerator<V>, IEnumerator<V>, IEnumerator<V>> f)
		{
			var last1 = velocities.Last;
			if (last1 != null) {
				var last2 = last1.Previous;
				if (last2 != null) {
					last2.Value = f(last2.Value, last1.Value);
					velocities.RemoveLast();
				}
			}
		}

		protected virtual IEnumerator<V> GetValueEnumerator()
		{
			for (;;) {
				yield return value;
			}
		}

		override protected void Reset()
		{
			base.Reset();
			elapsedTime = 0f;
			velocities.Clear();
		}

		protected virtual void Update()
		{
			var frame_prev = Mathf.FloorToInt(elapsedTime * FrameRate);
			elapsedTime += Time.deltaTime;
			var frame_next = Mathf.FloorToInt(elapsedTime * FrameRate);
			for (var f = frame_prev; f < frame_next; ++f) {
				var velocity = default(V);
				var node = velocities.First;
				while (node != null) {
					var next = node.Next;
					var v = node.Value;
					if (v.MoveNext()) {
						velocity = Add(velocity, v.Current);
					} else {
						velocities.Remove(node);
					}
					node = next;
				}
				value = Add(value, velocity);
				if (IsComplete) {
					enabled = false;
					NotifyComplete();
					break;
				}
			}
		}

		protected abstract V Add(V a, V b);
	}
}