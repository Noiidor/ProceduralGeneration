using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoiseFilterFactory
{
    public static INoiseFilter CreateNoiseFilter(NoiseSettingsOld settings)
    {
        switch (settings.filterType)
        {
            case NoiseSettingsOld.FilterType.Simple:
                return new SimpleNoiseFilter(settings.simpleNoiseSettings);
            case NoiseSettingsOld.FilterType.Ridgid:
                return new RidgidNoiseFilter(settings.ridgidNoiseSettings);
        }
        return null;
    }
}
