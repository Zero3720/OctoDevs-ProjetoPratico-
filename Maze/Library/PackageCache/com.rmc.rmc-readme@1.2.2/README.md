[![npm package](https://img.shields.io/npm/v/com.rmc.rmc-readme)](https://www.npmjs.com/package/com.rmc.rmc-readme)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)


<img width = "400" src="https://raw.githubusercontent.com/SamuelAsherRivello/rmc-core/main/RMC%20Core/Documentation~/com.rmc_namespace_logo.png" />

# RMC Readme

- [How To Use](#how-to-use)
- [Install](#install)
  - [Via NPM](#via-npm)
  - [Via Git URL](#via-git-url)
  - [Tests](#tests)
  - [Samples](#samples)
- [Configuration](#configuration)

<!-- toc -->

## How to use

This is a custom library to **display** a custom ReadMe for the Unity Inspector Window.

If you also want to **author** a custom ReadMe, see the https://github.com/SamuelAsherRivello/rmc-readme-authoring.


## Install

### Via NPM

You can either use the Unity Package Manager Window (UPM) or directly edit the manifest file. The result will be the same.

**UPM**

To use the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html), first add a [Scoped Registry](https://docs.unity3d.com/2023.1/Documentation/Manual/upm-scoped.html), then click on the interface menu ( `Status Bar → (+) Icon → Add Package By Name ...` ).

**Manifest File**

Or to edit the `Packages/manifest.json` directly with your favorite text editor, add a scoped registry then the following line(s) to dependencies block:

```json
{
  "scopedRegistries": [
    {
      "name": "npmjs",
      "url": "https://registry.npmjs.org/",
      "scopes": [
        "com.rmc"
      ]
    }
  ],
  "dependencies": {
    "com.rmc.rmc-readme": "1.2.2"
  }
}
```
Package should now appear in package manager.


### Via Git URL

You can either use the Unity Package Manager (UPM) Window or directly edit the manifest file. The result will be the same.

**UPM**

To use the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html) click on the interface menu ( `Status Bar → (+) Icon → Add Package From Git Url ...` ).

**Manifest File**

Or to edit the `Packages/manifest.json` directly with your favorite text editor, add following line(s) to the dependencies block:
```json
{
  "dependencies": {
      "com.rmc.rmc-readme": "https://github.com/SamuelAsherRivello/rmc-readme.git"
  }
}
```

### Tests

The package can optionally be set as *testable*.
In practice this means that tests in the package will be visible in the [Unity Test Runner](https://docs.unity3d.com/2017.4/Documentation/Manual/testing-editortestsrunner.html).

Open `Packages/manifest.json` with your favorite text editor. Add following line **after** the dependencies block:
```json
{
  "dependencies": {
  },
  "testables": [ "com.rmc.rmc-readme" ]
}
```

### Samples

Some packages include optional samples with clear use cases. To import and run the samples:

1. Open Unity 
1. Complete the package installation (See above)
1. Open the [Package Manager Window](https://docs.unity3d.com/Manual/upm-ui.html)
1. Select this package 
1. Select samples
1. Import

## Configuration

* `Unity Target` - [Standalone MAC/PC](https://support.unity.com/hc/en-us/articles/206336795-What-platforms-are-supported-by-Unity-)
* `Unity Version` - Any [Unity Editor](https://unity.com/download) 2021.x or higher
* `Unity Rendering` - Any [Unity Render Pipeline](https://docs.unity3d.com/Manual/universal-render-pipeline.html)
* `Unity Aspect Ratio` - Any [Unity Game View](https://docs.unity3d.com/Manual/GameView.html)


Created By
=============

- Samuel Asher Rivello 
- Over 23 years XP with game development (2023)
- Over 10 years XP with Unity (2023)

Contact
=============

- Twitter - <a href="https://twitter.com/srivello/">@srivello</a>
- Resume & Portfolio - <a href="http://www.SamuelAsherRivello.com">SamuelAsherRivello.com</a>
- Source Code on Git - <a href="https://github.com/SamuelAsherRivello/">Github.com/SamuelAsherRivello</a>
- LinkedIn - <a href="https://Linkedin.com/in/SamuelAsherRivello">Linkedin.com/in/SamuelAsherRivello</a> <--- Say Hello! :)

License
=============

Provided as-is under MIT License | Copyright © 2023 Rivello Multimedia Consulting, LLC






