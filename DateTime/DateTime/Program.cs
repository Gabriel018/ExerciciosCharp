var startDateLocal = new DateTime(2024, 03, 26, 0, 0, 0, DateTimeKind.Unspecified);
var endDateLocal = new DateTime(2024, 03, 26, 23, 59, 59, DateTimeKind.Unspecified);
// Convertendo para o fuso horário UTC
DateTime utcDate = TimeZoneInfo.ConvertTimeToUtc(startDateLocal);
DateTime utcDateEnd = TimeZoneInfo.ConvertTimeToUtc(endDateLocal);
Console.WriteLine("INI" + utcDate);
Console.WriteLine("FIM" + utcDateEnd);
Console.ReadKey();