# Unity_LicensePacker

<img src="https://github.com/XJINE/Unity_LicensePacker/blob/master/Screenshot.png" width="100%" height="auto" />

Pack some LICENSE files in Assets and Packages directories into one LICENSE file when build.

## Import to Your Project

You can import this asset from UnityPackage.

- [LicensePacker.unitypackage](https://github.com/XJINE/Unity_LicensePacker/blob/master/LicensePacker.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [TextFileReadWriter](https://github.com/XJINE/Unity_TextFileReadWriter)

## How to Use

LICENSE file is generated into a output folder when build is succeeded.

The LICENSE only includes packed assets LICENSE.
When any assets are not packed, these LICENSE are ignored.

Almost all of the Scripts are packed into a build assets.
Only some scripts in the "Editor" directories are ignored.

### File Name

Any extensions are valid. EX: .md, .txt or any others.
Ofcourse just "LICENCE" is also valid.

### LICENSE Name

LICENSE file must be put in the directory which shows the name.

EX: Assets/SampleScript/LICENSE gets the License name "SampleScript"

### Settings

There are some settings in a Menu "Custom > LicensePacker".

Some LICENSE are enable to ignored to use "IgnoreDirectoriesStartsWith".

EX:"unity.com" ignored some default packages in PackageManagers.

"Split" is the text to use Split the LICENSE Name and LICENSE Text.