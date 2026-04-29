@mainpage Modular Architecture - Home

## Overview

Modular architecture is a small Unity package designed to provide structured re-usable data-driven pieces of code that can be used and expanded upon in your own Unity projects. Unity's codebase is inherently quite tightly coupled with the reign of Mono Behaviour and whilst it works and the workflow is very simple it has shortcomings. Throughout the years more and more Unity developers have been finding success with encorporating more modular and composite based designs into their Unity work-flows. 

Some Excellent Resources and the inspiration behind this package : 
- [Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=1530s)
- [Overthrowing the MonoBehaviour Tyranny](https://www.youtube.com/watch?v=6vmRwLYWNRo )

### The Benefits to Modularity In Unity

- Fewer dependencies — MonoBehaviour‑heavy setups often create tangled scene references; modular systems stay clean and isolated
- Safer iteration — swapping or updating modules (input, UI, audio, etc.) won’t impact unrelated features
- Easier testing — data‑driven modules avoid scene‑reset issues and reduce dependency headaches
- Better organization — Unity’s asset workflow pairs naturally with ScriptableObjects and persistent data
- Memory efficiency — multiple objects can read from a single data asset, avoiding unnecessary duplication

### Features

- Create-able data assets for IComparable Data Types 
- Modular data game event system
- Modular data conditions system ( return a `operator` b )  
- Extendable Enums (Cory Koseck) and Extendable Enum Data Sets
- Custom property drawers
- Samples and Demos

## Package Structure 

I created this package from the base of an earlier project I had made called PackageTemplate which can be found at : https://github.com/RyanEllisDale/PackageTemplate in both of these packages I have attempted to follow the established Unity and community standards. 
The resources I used for my packaging layout and code standards can be found at : 

- Unity’s Official Package Layout: https://docs.unity3d.com/6000.3/Documentation/Manual/cus-layout.html
- Unity’s Code Standard Tips: https://unity.com/how-to/naming-and-code-style-tips-c-scripting-unity
- uvasgd’s Unity Documentation Tips: https://uvasgd.github.io/sgd-docs/unity/documentation.html

The changelog follows Unity and *Keep a ChangeLog* conventions which can be found at : 

- Unity Changelog Guidelines: https://docs.unity3d.com/6000.3/Documentation/Manual/cus-changelog.html  
- Keep a Changelog: https://keepachangelog.com/en/1.1.0/

Throughout the whole project, Semantic versioning is used, and a generally consistent Markdown styling is kept, 
A guide to both can be found at : 

- Semantic Versioning: https://semver.org/spec/v2.0.0.html  
- Markdown Syntax Guide: https://markdownguide.offshoot.io/basic-syntax/ 

## Documentation 

The documentation for this package is generated using Doxygen, styled with the doxygen‑awesome theme, and built directly from the XML comments within the codebase. This ensures that the documentation stays accurate, up‑to‑date, and closely aligned with the implementation. It also allows contributors to improve the docs simply by enhancing the inline comments in the source files. If you find any errors in the codebase feel free to toy around as much as you want and send me your findings, I'd love to hear from you.

- Doxygen : https://www.doxygen.nl/
- doxygen-awesome-css : https://github.com/jothepro/doxygen-awesome-css 

## Thank You For Reading 

### `Suggested Readings`
@ref Installation "How to install the package"

@ref How-To-Use "How to use the package"

[Credits](https://ryanellisdale.github.io/ModularArchitecture/md__documentation_2_credits.html)

[Third Party Notices](https://ryanellisdale.github.io/ModularArchitecture/md__third_01_party_01_notices.html)

[Licensing](https://ryanellisdale.github.io/ModularArchitecture/md__l_i_c_e_n_s_e.html)


@page Installation

The modular architecture package can be added to your Unity project in three ways. The first two use the Package Manager, while the third is a manual fallback if the Package Manager is unavailable.

## Package Manager 

You can access the Package Manager by opening your Unity project, selecting **Window** from the top menu bar, and choosing **Package Manager**.  
In the top‑left corner of the Package Manager window, the **➕ (Add)** button allows you to install external packages.

This package supports two Package Manager installation methods:

- **Add package from disk**  
- **Add package from Git URL**

<details>
<summary>Resources:</summary>
- https://docs.unity3d.com/6000.4/Documentation/Manual/upm-ui.html  
- https://docs.unity3d.com/6000.4/Documentation/Manual/PackagesList.html
</details>

### Package Manager Disk

To install from disk, download and extract the package, place it anywhere on your machine, then select **Add package from disk** and point Unity to the folder. Packages installed this way are *local* and not stored inside the project.  
If the folder is moved or deleted, Unity will lose the reference and you’ll need to re‑add it.

<details>
<summary>Resources:</summary>
- https://docs.unity3d.com/2020.1/Documentation/Manual/upm-ui-local.html
</details>

### Package Manager — Git

This is the simplest way to add the package to your project.  
Open the Package Manager, click the **Add** button, and select **Add package from Git URL**. Unity will prompt you for a valid Git URL. <br/>
Use : https://github.com/RyanEllisDale/ModularArchitecture.git


You can also find this URL on the project’s GitHub page:  
https://github.com/RyanEllisDale/ModularArchitecture

Installing the package this way prevents editing the package directly inside your project, but allows you to update it at any time through the Package Manager.

<details>
<summary>Resources:</summary>
- https://docs.unity3d.com/2020.1/Documentation/Manual/upm-ui-giturl.html
- https://github.com/RyanEllisDale/ModularArchitecture.git
- https://github.com/RyanEllisDale/ModularArchitecture
</details>

## Manual Install

Manual installation is also possible if the Package Manager is unavailable or not preferred.  
To install the package manually, download and extract it, then place the extracted folder inside your project's `Packages/` directory (located in the project root). If the `Packages/` folder does not exist, create it manually.

Ensure that you copy only the package’s root folder — the one that directly contains the `package.json` file.


## Thank You For Reading 

### `Suggested Readings`

@ref How-To-Use "How to use the package"

[Credits](https://ryanellisdale.github.io/ModularArchitecture/md__documentation_2_credits.html)

[Third Party Notices](https://ryanellisdale.github.io/ModularArchitecture/md__third_01_party_01_notices.html)

[Licensing](https://ryanellisdale.github.io/ModularArchitecture/md__l_i_c_e_n_s_e.html)

@page How-To-Use

### 







## Thank You For Reading 

### `Suggested Readings`
@ref Installation "How to install the package"

[Credits](https://ryanellisdale.github.io/ModularArchitecture/md__documentation_2_credits.html)

[Third Party Notices](https://ryanellisdale.github.io/ModularArchitecture/md__third_01_party_01_notices.html)

[Licensing](https://ryanellisdale.github.io/ModularArchitecture/md__l_i_c_e_n_s_e.html)