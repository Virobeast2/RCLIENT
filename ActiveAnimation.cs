﻿using AnimationOrTween;
using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animation)), AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : IgnoreTimeScale
{
    public string callWhenFinished;
    public GameObject eventReceiver;
    private Animation mAnim;
    private AnimationOrTween.Direction mDisableDirection;
    private AnimationOrTween.Direction mLastDirection;
    private bool mNotify;

    private void Play(string clipName, AnimationOrTween.Direction playDirection)
    {
        if (this.mAnim != null)
        {
            this.mAnim.enabled = false;
            if (playDirection == AnimationOrTween.Direction.Toggle)
            {
                playDirection = (this.mLastDirection == AnimationOrTween.Direction.Forward) ? AnimationOrTween.Direction.Reverse : AnimationOrTween.Direction.Forward;
            }
            if (string.IsNullOrEmpty(clipName))
            {
                if (!this.mAnim.isPlaying)
                {
                    this.mAnim.Play();
                }
            }
            else if (!this.mAnim.IsPlaying(clipName))
            {
                this.mAnim.Play(clipName);
            }
            IEnumerator enumerator = this.mAnim.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    AnimationState current = (AnimationState) enumerator.Current;
                    if (string.IsNullOrEmpty(clipName) || (current.name == clipName))
                    {
                        float num = Mathf.Abs(current.speed);
                        current.speed = num * ((float) playDirection);
                        if ((playDirection == AnimationOrTween.Direction.Reverse) && (current.time == 0f))
                        {
                            current.time = current.length;
                        }
                        else if ((playDirection == AnimationOrTween.Direction.Forward) && (current.time == current.length))
                        {
                            current.time = 0f;
                        }
                    }
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable == null)
                {
                }
                disposable.Dispose();
            }
            this.mLastDirection = playDirection;
            this.mNotify = true;
        }
    }

    public static ActiveAnimation Play(Animation anim, AnimationOrTween.Direction playDirection)
    {
        return Play(anim, null, playDirection, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
    }

    public static ActiveAnimation Play(Animation anim, string clipName, AnimationOrTween.Direction playDirection)
    {
        return Play(anim, clipName, playDirection, EnableCondition.DoNothing, DisableCondition.DoNotDisable);
    }

    public static ActiveAnimation Play(Animation anim, string clipName, AnimationOrTween.Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
    {
        if (!anim.gameObject.activeInHierarchy)
        {
            if (enableBeforePlay != EnableCondition.EnableThenPlay)
            {
                return null;
            }
            NGUITools.SetActive(anim.gameObject, true);
        }
        ActiveAnimation component = anim.GetComponent<ActiveAnimation>();
        if (component != null)
        {
            component.enabled = true;
        }
        else
        {
            component = anim.gameObject.AddComponent<ActiveAnimation>();
        }
        component.mAnim = anim;
        component.mDisableDirection = (AnimationOrTween.Direction) disableCondition;
        component.Play(clipName, playDirection);
        return component;
    }

    public void Reset()
    {
        if (this.mAnim != null)
        {
            IEnumerator enumerator = this.mAnim.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    AnimationState current = (AnimationState) enumerator.Current;
                    if (this.mLastDirection == AnimationOrTween.Direction.Reverse)
                    {
                        current.time = current.length;
                    }
                    else if (this.mLastDirection == AnimationOrTween.Direction.Forward)
                    {
                        current.time = 0f;
                    }
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable == null)
                {
                }
                disposable.Dispose();
            }
        }
    }

    private void Update()
    {
        float num = base.UpdateRealTimeDelta();
        if (num != 0f)
        {
            if (this.mAnim != null)
            {
                bool flag = false;
                IEnumerator enumerator = this.mAnim.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        AnimationState current = (AnimationState) enumerator.Current;
                        float num2 = current.speed * num;
                        current.time += num2;
                        if (num2 < 0f)
                        {
                            if (current.time > 0f)
                            {
                                flag = true;
                            }
                            else
                            {
                                current.time = 0f;
                            }
                        }
                        else if (current.time < current.length)
                        {
                            flag = true;
                        }
                        else
                        {
                            current.time = current.length;
                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable == null)
                    {
                    }
                    disposable.Dispose();
                }
                this.mAnim.enabled = true;
                this.mAnim.Sample();
                this.mAnim.enabled = false;
                if (flag)
                {
                    return;
                }
                if (this.mNotify)
                {
                    this.mNotify = false;
                    if ((this.eventReceiver != null) && !string.IsNullOrEmpty(this.callWhenFinished))
                    {
                        this.eventReceiver.SendMessage(this.callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
                    }
                    if ((this.mDisableDirection != AnimationOrTween.Direction.Toggle) && (this.mLastDirection == this.mDisableDirection))
                    {
                        NGUITools.SetActive(base.gameObject, false);
                    }
                }
            }
            base.enabled = false;
        }
    }
}

