# Creative Coding in Unity

This is repo for creative coding course (workshop, tutorial? idk) from channel9. Source: <https://channel9.msdn.com/Series/UnityCreativeCoding>

## NOTES 

I've had a problem: my gameObjects were black after adding a Light Probe to the scene. This problem appears only when I use Realtime Lighting. When I switch to Mixed Lighting and enable check for Baked Global Illumination in Light Settings, my problem was gone.

If baking is slow, selecting Progressive GPU (which is in preview status in 2019.3.0f6) in Lightmapping Setting -> Lightmapper should help.

