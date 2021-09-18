using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoiseFilterFactory 
{
    public static INoiseFilter CreateNoiseFilter(NoiseSettings settings)
    {
        switch (settings.filterType)
        {
            case NoiseSettings.FilterType.Simple:
                return new NoiseFilter(settings.simpleNoiseSettings);
            case NoiseSettings.FilterType.Rigid:
                return new NoiseFilter(settings.rigidNoiseSettings);
        }
        return null;
    }
}
