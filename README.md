# maetschke-simpleui-package
 
[![Template Unity Package documentation](https://github.com/OmiyaGames/template-unity-package/workflows/Host%20DocFX%20Documentation/badge.svg)](https://omiyagames.github.io/template-unity-package/) [![Ko-fi Badge](https://img.shields.io/badge/donate-ko--fi-29abe0.svg?logo=ko-fi)](https://ko-fi.com/I3I51KS8F) [![License Badge](https://img.shields.io/github/license/OmiyaGames/template-unity-package)](/LICENSE.md)

![Unity Package Manager]()


## Documentation

- [File and Folder Structure](https://omiyagames.github.io/template-unity-package/manual/structure.html)
- [Customizing Package Files](https://omiyagames.github.io/template-unity-package/manual/customizePackage.html)
- [Adding Source Code and Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSource.html)
- [Adding Importable Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSamples.html)
- [Customizing Documentation](https://omiyagames.github.io/template-unity-package/manual/customizeDocumentation.html)

Finally, changes in the project is documented under the [change log page](https://omiyagames.github.io/template-unity-package/manual/changelog.html).

## Install

For ease of updating installation instructions in future projects, a template instruction is specified below.  Note that [instructions on using OpenUPM's](#through-openupm) to install *this* template package is merely theoretical, as this project is not actually hosted in OpenUPM:

There are two common methods for installing this package.

### Through [OpenUPM](https://openupm.com/)

Installing via [OpenUPM's command line tool](https://openupm.com/) is recommended because it supports dependency resolution, upgrading, and downgrading this package.

If you haven't already [installed OpenUPM](https://openupm.com/docs/getting-started.html#installing-openupm-cli), you can do so through Node.js's `npm` (obviously have Node.js installed in your system first):
```
npm install -g openupm-cli
```
Then, to install this package, just run the following command at the root of your Unity project:
```
openupm add com.omiyagames.template
```

### Through [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

Unity's own Package Manager supports [importing packages through a URL to a Git repo](https://docs.unity3d.com/Manual/upm-ui-giturl.html):

1. First, on this repository page, click the "Clone or download" button, and copy over this repository's HTTPS URL.  
2. Then click on the + button on the upper-left-hand corner of the Package Manager, select "Add package from git URL..." on the context menu, then paste this repo's URL!

While easier to follow than the first method, this one does not support dependency resolution and package upgrading when a new version is released.  So proceed with caution.

## Resources

- [Documentation](https://omiyagames.github.io/template-unity-package/)
- [Change Log](/CHANGELOG.md)

## LICENSE

Overall package is licensed under [MIT](/LICENSE.md), unless otherwise noted in the [3rd party licenses](/THIRD%20PARTY%20NOTICES.md) file and/or source code.

Copyright (c) 2019-2022 Omiya Games
