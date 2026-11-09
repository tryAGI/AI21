# AI21.CLI

Command-line interface for the AI21 SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global AI21.CLI --prerelease
```

## Usage

```bash
ai21 --help
ai21 api --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
ai21 completion bash > /usr/local/etc/bash_completion.d/ai21
ai21 completion zsh  > _ai21   # then put it on your zsh fpath
ai21 completion fish > ~/.config/fish/completions/ai21.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.