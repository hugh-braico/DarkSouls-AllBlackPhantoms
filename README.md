# Dark Souls All Black Phantoms

Utility that does exactly what it sounds like, it makes all regular enemies and bosses their Gravelord Black Phantom versions, with modified appearance, health, and damage. They also respawn when you quit and reload (except for bosses), making quitout cheese less effective or even counterproductive in some situations.

Intended for challenge runs, and lets you push the game's difficulty past NG+6 (the last NG+ cycle to feature an increase in difficulty).

Why you might want to use this over the mod [All enemies are Gravelord Phantoms](https://www.nexusmods.com/darksouls/mods/1176), also by RavagerChris37:

- It modifies params in place without replacing whole files, so it has high compatibility with other mods.
- It works with both PTDE and DSR, whereas that mod only works with PTDE.

**Does not make you perma-gravelorded**, so the extra Black Phantom enemies that usually appear when gravelorded won't appear. If you want that, this mod is compatible with [Perma Vagrant Gravelord](https://www.nexusmods.com/darksouls/mods/1381) by RavagerChris37, which works with both PTDE and DSR.

## How to use

If you're using PTDE, you'll need to [unpack your files for modding](https://github.com/HotPocketRemix/UnpackDarkSoulsForModding) to work. DSR's files are already unpacked, so that's not a problem.

Just download the [latest release](https://github.com/hugh-braico/DarkSouls-AllBlackPhantoms/releases), extract it somewhere (doesn't matter where), and run the exe. Should be self-explanatory enough from there.

## Internals

The difference parameter-wise between a regular enemy and its black phantom version is:

- Black phantom enemies have the effect `Special Effect ID 6 = 7100`, which gives them their stat buffs.
  - There are multiple slots for special effects. Sometimes this slot is taken up with something else, in which case the program attempts to fill another slot.
- Black phantom enemies have `disableInitializeDead = true`, which means they respawn when you quit and reload.
- Black phantom enemies have `DrawType = 2`, which gives them their unique appearance.
  - This doesn't appear to work for all enemies (especially friendly NPCs), I don't really know why to be honest.

Some additional things that are sometimes different in black phantoms that this mod does not change, just to be on the safe side:

- Some black phantom enemies have different Item Lots (drop tables) to their regular version. I don't know why this is.
- Some black phantom enemies have different Humanity Lot Id, which is likely related to Humanity Drop.

All these params are kept inside the "NpcParam" param type. Useful links:

- [NpcParam (Souls Modding Wiki)](https://soulsmodding.wikidot.com/param:npcparam)
- [Param compilation on Google Drive](https://docs.google.com/spreadsheets/d/1KukblWL61We64-gNIyaAShga9h8RTXYmyFs98eQhY4E/edit?usp=sharing) - see the "NPCs" tab

## Acknowledgements

This uses some of the code from Meowmaritus's fork of [Paramdomizer](https://github.com/Meowmaritus/Paramdomizer). Since they fundamentally do something very similar (open the params file and change some stuff), I thought it made sense to just build on top of that.

Uses Meowmaritus's DSIO as a dependency by adding it as a git submodule. MeowDSIO is MIT-licensed software.
