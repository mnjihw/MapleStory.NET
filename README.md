# MapleStory.NET

[![NuGet](https://img.shields.io/nuget/v/MapleStory.NET)](https://www.nuget.org/packages/MapleStory.NET)

MapleStory.NET is a wrapper to simplify the use of Nexon's MapleStory Open API, which offers functionality for retrieving data, such as character details, cube usage results, and various rankings.

[Click here](README-ko.md) to read in Korean.  
한국어로 읽으려면 [여기를 클릭하세요.](README-ko.md)

## Installation

```xml
dotnet add package MapleStory.NET
```

## How to use

### API Key

API Key will be generated once you register your application on [Nexon Open API Center](https://openapi.nexon.com/my-application/).

### Example code

```csharp
using System;
using MapleStory.NET;

var apiKey = "Your api key here";

using var client = new MapleStoryClient(apiKey);
var overallRankingResult = await client.RankingApi.GetOverallRankingAsync(); //fetch overall ranking

if (!overallRankingResult.Success)
{
    Console.WriteLine(overallRankingResult.Error);
    return;
}

var characterName = overallRankingResult.Data.Ranking[0].CharacterName;
var characterResult = await client.CharacterApi.GetAsync(characterName); //fetch character identifier(ocid)

if (!characterResult.Success)
{
    Console.WriteLine(characterResult.Error);
    return;
}
var ocid = characterResult.Data.Ocid;
var characterBasicResult = await client.CharacterApi.GetBasicAsync(ocid); //fetch basic information

if (!characterBasicResult.Success)
{
    Console.WriteLine(characterBasicResult.Error);
    return;
}

var characterBasic = characterBasicResult.Data;
Console.WriteLine(characterBasic.ToJsonString());
```
