# [CST.NET](http://CST.NET)

&lt;p align="center"&gt;&lt;a href="https://github.com/tonytins/cstdotnet/blob/main/LICENSE"&gt;&lt;img src="https://img.shields.io/github/license/tonytins/cstdotnet" alt="GitHub license"&gt;&lt;/a&gt; &lt;a href="https://github.com/tonytins/cstdotnet/actions?query=workflow%3Abuild.yml"&gt;&lt;img src="https://img.shields.io/github/actions/workflow/status/tonytins/cstdotnet/build.yml" alt="GitHub Workflow Status"&gt;&lt;/a&gt; &lt;img src="https://img.shields.io/github/commit-activity/w/tonytins/cstdotnet" alt="GitHub commit activity"&gt; &lt;a href="code_of_conduct.md"&gt;&lt;/br&gt; &lt;img src="https://img.shields.io/codeclimate/maintainability-percentage/tonytins/cstdotnet" alt="Code Climate maintainability"&gt; &lt;img src="https://img.shields.io/nuget/dt/CSTNet" alt="NuGet Downloads"&gt; &lt;a href="https://www.nuget.org/packages/tonybark.updatetools"&gt;&lt;img src="https://img.shields.io/nuget/v/cstnet.svg" /&gt;&lt;/a&gt;&lt;/br&gt;&lt;img src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg" alt="Contributor Covenant"&gt;&lt;/a&gt;&lt;/br&gt; &lt;/p&gt;

CST.NET is a library for parsing Maxis' key-value pair format. It can be used in conjunction with your own custom frameworks, or the original `UIText` APIs.

Caret-Separated Text (or CST) is a key-value pair format represented by digits or words as keys and the value as text enclosed between carets. (e.g. `<key> ^<text>^`) Any text which is not enclosed with carets is considered a comment and ignored. Neither strings nor comments may use the caret character.

## Changelog

See [changelog.md](./doc/changelog.md)

## Usage

See [/docs](./doc/README.md).

## To-do

- [ ] Support for parameters (e.g. `%1`)

## Known issues

- Skipping comments is a little unpredictable.

## Requirements

- [.NET](https://dotnet.microsoft.com/download) 6 or later.
- IDEs or Editors
  - [Visual Studio Code](https://code.visualstudio.com/)
  - [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET Interactive](https://github.com/dotnet/interactive/blob/main/README.md) for notebooks (optional).
  - [VSCode Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode) or [nteract](https://nteract.io/).


# Contributing

You can contribute to CST.NET by testing cutting edge features in the latest releases, filing bugs, and joining in the discussion on our forums!

* [Getting Started](https://github.com/tonytins/cstdotnet/wiki)
* [Project Structure](https://github.com/tonytins/cstdotnet/wiki/Project-structure)
* [Coding Standards](https://github.com/tonytins/cstdotnet/wiki/Coding-standards)
* [Pull Requests](https://github.com/tonytins/cstdotnet/pulls): [Open](https://github.com/tonytins/cstdotnet/pulls)/[Closed](https://github.com/tonytins/cstdotnet/issues?q=is%3Apr+is%3Aclosed)

Looking for something to do? Check out the issues tagged as [help wanted](https://github.com/tonytins/cstdotnet/labels/help%20wanted) to get started.

Regarding translations, full object and UI translations should currently be released on the forums. This is far from perfect and is due to be reworked. Stay tuned!

## License

I license this project under the BSD-3-Clause license - see [LICENSE](LICENSE) for details.