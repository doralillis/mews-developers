namespace Mews.BackendDeveloperTask.ExchangeRates;

public record ExchangeRate(Currency Source, Currency Target, decimal Rate);
