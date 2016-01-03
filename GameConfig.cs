using JSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
    [NonSerialized]
    public bool isLoaded;
    [NonSerialized]
    public JSON.Object json;
    public string jsonURL;
    public Action<JSON.Object> onUpdated;
    public string storeKey;
    public float updateMinutes;

    private void LoadFrom(string strData)
    {
        JSON.Object obj2 = null;
        try
        {
            obj2 = JSON.Object.Parse(strData);
        }
        catch (Exception)
        {
            return;
        }
        if (obj2 != null)
        {
            try
            {
                PlayerPrefs.SetString(this.storeKey, strData);
            }
            catch (Exception)
            {
            }
            this.json = obj2;
            this.isLoaded = true;
            if (this.onUpdated != null)
            {
                this.onUpdated(this.json);
            }
        }
    }

    [DebuggerHidden]
    private IEnumerator LoadFromURL()
    {
        return new <LoadFromURL>c__Iterator4E { <>f__this = this };
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey(this.storeKey))
        {
            this.LoadFrom(PlayerPrefs.GetString(this.storeKey));
        }
        base.StartCoroutine(this.LoadFromURL());
    }

    [CompilerGenerated]
    private sealed class <LoadFromURL>c__Iterator4E : IDisposable, IEnumerator, IEnumerator<object>
    {
        internal object $current;
        internal int $PC;
        internal GameConfig <>f__this;
        internal WWW <www>__0;

        [DebuggerHidden]
        public void Dispose()
        {
            this.$PC = -1;
        }

        public bool MoveNext()
        {
            uint num = (uint) this.$PC;
            this.$PC = -1;
            switch (num)
            {
                case 0:
                case 2:
                case 3:
                    this.<www>__0 = new WWW(this.<>f__this.jsonURL);
                    this.$current = this.<www>__0;
                    this.$PC = 1;
                    goto Label_00F3;

                case 1:
                    if (string.IsNullOrEmpty(this.<www>__0.error))
                    {
                        this.<>f__this.LoadFrom(this.<www>__0.text);
                        this.$current = new WaitForSeconds(this.<>f__this.updateMinutes * 60f);
                        this.$PC = 2;
                    }
                    else
                    {
                        UnityEngine.Debug.LogWarning("GameConfig: " + this.<www>__0.error);
                        this.$current = new WaitForSeconds(30f);
                        this.$PC = 3;
                    }
                    goto Label_00F3;

                default:
                    break;
                    this.$PC = -1;
                    break;
            }
            return false;
        Label_00F3:
            return true;
        }

        [DebuggerHidden]
        public void Reset()
        {
            throw new NotSupportedException();
        }

        object IEnumerator<object>.Current
        {
            [DebuggerHidden]
            get
            {
                return this.$current;
            }
        }

        object IEnumerator.Current
        {
            [DebuggerHidden]
            get
            {
                return this.$current;
            }
        }
    }
}

