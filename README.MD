# Creative Coding in Unity

This is repo for creative coding course (workshop, tutorial? idk) from channel9. Source: <https://channel9.msdn.com/Series/UnityCreativeCoding>

## NOTES 

I've had a problem when my gameObjects were black after adding a Light Probe to the scene. It appears only when I use Realtime Lighting; when I switch to Mixed Lighting and check Baked Global Illumination in Light Settings, my problem was gone off.

But baking is slow, so it should be selected Progressive GPU (which is in preview status in 2019.3.0f6) in Lightmapping Setting -> Lightmapper.

