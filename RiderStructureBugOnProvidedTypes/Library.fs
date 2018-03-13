module Test

open FSharp.Configuration

type Settings = YamlConfig<YamlText = """
Entity:
  IntParam: 22
""">
