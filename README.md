# Template Mod
Yet another template repository for making BepInEx mods for [ATLYSS](https://store.steampowered.com/app/2768430/ATLYSS/).  

The main goal with this template is to simplify the build process by avoiding additional dependencies like Python and using MS Build to automate it.  

Part of the project was created using the custom [BepInEx 5 Plugin](https://github.com/BepInEx/BepInEx.Templates) template, and it can be used to add more projects to this solution if desired.

### Building
1. Open [Directory.Build.props](Directory.Build.props) in a text editor.
2. Edit the ATLYSS_PATH property to point to your local game path where the executable can be found.

### Requirements
* [BepInEx 5](https://github.com/BepInEx/BepInEx)
