using System;

public class gfx : ConsoleSystem
{
    [ConsoleSystem.Client]
    public static bool all
    {
        get
        {
            return ((((ssaa && bloom) && (grain && ssao)) && (tonemap && shafts)) && damage);
        }
        set
        {
            bool flag = value;
            damage = flag;
            shafts = flag;
            tonemap = flag;
            ssao = flag;
            grain = flag;
            bloom = flag;
            ssaa = flag;
        }
    }

    [ConsoleSystem.Client, Saved]
    public static bool bloom
    {
        get
        {
            return ImageEffectManager.GetEnabled<Bloom>();
        }
        set
        {
            ImageEffectManager.SetEnabled<Bloom>(value);
        }
    }

    [Saved, ConsoleSystem.Client]
    public static bool damage
    {
        get
        {
            return ImageEffectManager.GetEnabled<GameFullscreen>();
        }
        set
        {
            ImageEffectManager.SetEnabled<GameFullscreen>(value);
        }
    }

    [ConsoleSystem.Client, Saved]
    public static bool grain
    {
        get
        {
            return ImageEffectManager.GetEnabled<NoiseAndGrain>();
        }
        set
        {
            ImageEffectManager.SetEnabled<NoiseAndGrain>(value);
        }
    }

    [ConsoleSystem.Client, Saved]
    public static bool shafts
    {
        get
        {
            return ImageEffectManager.GetEnabled<TOD_SunShafts>();
        }
        set
        {
            ImageEffectManager.SetEnabled<TOD_SunShafts>(value);
        }
    }

    [Saved, ConsoleSystem.Client]
    public static bool ssaa
    {
        get
        {
            return ImageEffectManager.GetEnabled<AntialiasingAsPostEffect>();
        }
        set
        {
            ImageEffectManager.SetEnabled<AntialiasingAsPostEffect>(value);
        }
    }

    [Saved, ConsoleSystem.Client]
    public static bool ssao
    {
        get
        {
            return ImageEffectManager.GetEnabled<SSAOEffect>();
        }
        set
        {
            ImageEffectManager.SetEnabled<SSAOEffect>(value);
        }
    }

    [ConsoleSystem.Client, Saved]
    public static bool tonemap
    {
        get
        {
            return ImageEffectManager.GetEnabled<Tonemapping>();
        }
        set
        {
            ImageEffectManager.SetEnabled<Tonemapping>(value);
        }
    }
}

