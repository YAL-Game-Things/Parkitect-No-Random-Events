# No Random Events
This mod disables all [random events](https://github.com/YAL-Game-Things/Parkitect-guide/blob/main/0301-Events.md).

Originally I was going to make a mod that disables the "vandalism wave" event specifically
(as I didn't like having vandals _or_ a horde of security officers in a "coaster test" park),
but I later figured that even the positive events can throw off metrics.

Note that rides breaking is not the same kind of a "random event".

## Setting Up

- Clone the repository
- Copy Parkitect DLLs from `Parkitect/Parkitect_Data/Managed` to `Libs/`
- Download [Harmony](https://github.com/pardeike/Harmony/releases/tag/v2.2.2.0) and copy `net472/0Harmony.dll` to `Libs/`

## Building

Open the Visual Studio project and compile. Post-build event should automatically copy the necessary files to the game's `Mods` sub-directory inside My Documents.

## Credits
- Mod by [YellowAfterlife](https://yal.cc).
