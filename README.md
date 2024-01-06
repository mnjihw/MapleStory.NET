# MapleStory.NET

English | [한국어](README-ko.md)

[![NuGet](https://img.shields.io/nuget/v/MapleStory.NET)](https://www.nuget.org/packages/MapleStory.NET)

MapleStory.NET is a wrapper to simplify the use of Nexon's MapleStory Open API, which offers functionality for retrieving data, such as character details, cube usage results, and various rankings.

## Installation

```xml
dotnet add package MapleStory.NET
```

## How to use

### API Key

API Key will be generated once you register your application on [Nexon Open API Center](https://openapi.nexon.com/my-application/).

### Example code

```csharp
using MapleStory.NET;

var apiKey = "Your_api_key_here";

using var httpClient = new HttpClient();
var client = new MapleStoryClient(httpClient, apiKey);
var overallRankingResult = await client.RankingApi.GetOverallRankingAsync(); //fetch overall ranking

if (!overallRankingResult.Success)
{
    Console.WriteLine(overallRankingResult.Error);
    return;
}

var top10 = overallRankingResult.Data!.Ranking!.Take(10); //get top 10 characters
var firstPlace = top10.First(); //get first place
var characterResult = await client.CharacterApi.GetAsync(firstPlace.CharacterName!); //fetch character identifier(ocid)

if (!characterResult.Success)
{
    Console.WriteLine(characterResult.Error);
    return;
}

var ocid = characterResult.Data!.Ocid!;
var characterBasicResult = await client.CharacterApi.GetBasicAsync(ocid); //fetch basic data

if (!characterBasicResult.Success)
{
    Console.WriteLine(characterBasicResult.Error);
    return;
}

var characterBasic = characterBasicResult.Data;
Console.WriteLine(characterBasic.ToJsonString());
```
