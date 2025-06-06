﻿using System.Text.Json.Serialization;

namespace TTX.Api.Dto;

public class PaginationDto<T>
{
    [JsonPropertyName("data")] public required T[] Data { get; init; }

    [JsonPropertyName("total")] public required int Total { get; init; }
}