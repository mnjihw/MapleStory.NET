# MapleStory.NET

[![NuGet](https://img.shields.io/nuget/v/MapleStory.NET)](https://www.nuget.org/packages/MapleStory.NET)

MapleStory.NET은 넥슨의 MapleStory Open API 사용을 간소화하기 위한 래퍼 라이브러리로,  
캐릭터 세부 정보, 큐브 사용 결과 및 다양한 랭킹 등의 데이터를 조회하는 기능을 제공합니다.

영어로 읽으려면 [여기를 클릭하세요.](README.md)  
[Click here](README.md) to read in English.

## 설치

```xml
dotnet add package MapleStory.NET
```

## 사용 방법

### API Key 발급받기

[Nexon Open API 센터](https://openapi.nexon.com/my-application/)에서 애플리케이션을 등록하면 API Key가 발급됩니다.

### 예제 코드

```csharp
using MapleStory.NET;

var apiKey = "Your_api_key_here";

using var httpClient = new HttpClient();
var client = new MapleStoryClient(httpClient, apiKey);
var overallRankingResult = await client.RankingApi.GetOverallRankingAsync(); //종합 랭킹 정보 조회

if (!overallRankingResult.Success)
{
    Console.WriteLine(overallRankingResult.Error);
    return;
}

var top10 = overallRankingResult.Data!.Ranking!.Take(10); //랭킹 10위까지 가져오기
var firstPlace = top10.First(); //랭킹 1위 가져오기
var characterResult = await client.CharacterApi.GetAsync(firstPlace.CharacterName!); //캐릭터 식별자(ocid) 조회

if (!characterResult.Success)
{
    Console.WriteLine(characterResult.Error);
    return;
}

var ocid = characterResult.Data!.Ocid!;
var characterBasicResult = await client.CharacterApi.GetBasicAsync(ocid); //기본 정보 조회

if (!characterBasicResult.Success)
{
    Console.WriteLine(characterBasicResult.Error);
    return;
}

var characterBasic = characterBasicResult.Data;
Console.WriteLine(characterBasic.ToJsonString());
```
