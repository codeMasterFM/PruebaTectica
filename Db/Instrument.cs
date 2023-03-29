using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db
{
    public class Instrument
    {
        [Key]
        public string? symbol { get; set; }
        public string? rootSymbol { get; set; }
        public string? state { get; set; }
        public string? typ { get; set; }
        public DateTime? listing { get; set; }
        public DateTime? front { get; set; }
        public DateTime? expiry { get; set; }
        public DateTime? settle { get; set; }
        public DateTime? listedSettle { get; set; }
        [NotMapped]
        public long? relistInterval { get; set; }
        public string? positionCurrency { get; set; }
        public string? underlying { get; set; }
        public string? quoteCurrency { get; set; }
        public string? underlyingSymbol { get; set; }
        public string? reference { get; set; }
        public string? referenceSymbol { get; set; }
        public DateTime? calcInterval { get; set; }
        public DateTime? publishInterval { get; set; }
        public DateTime? publishTime { get; set; }
        public long? maxOrderQty { get; set; }
        public long? maxPrice { get; set; }
        public long? lotSize { get; set; }
        public double? tickSize { get; set; }
        public long? multiplier { get; set; }
        public string? settlCurrency { get; set; }
        public long? underlyingToPositionMultiplier { get; set; }
        public long? underlyingToSettleMultiplier { get; set; }
        public long? quoteToSettleMultiplier { get; set; }
        public bool? isQuanto { get; set; }
        public bool? isInverse { get; set; }
        public double? initMargin { get; set; }
        public double? maintMargin { get; set; }
        public long? riskLimit { get; set; }
        public long? riskStep { get; set; }
        public double? limit { get; set; }
        public bool? taxed { get; set; }
        public bool? deleverage { get; set; }
        public double? makerFee { get; set; }
        public double? takerFee { get; set; }
        public double? settlementFee { get; set; }
        public string? fundingBaseSymbol { get; set; }
        public string? fundingQuoteSymbol { get; set; }
        public string? fundingPremiumSymbol { get; set; }
        public DateTime? fundingTimestamp { get; set; }
        public DateTime? fundingInterval { get; set; }
        public float? fundingRate { get; set; }
        [NotMapped]
        public object? indicativeFundingRate { get; set; }
        public DateTime? rebalanceTimestamp { get; set; }
        public DateTime? rebalanceInterval { get; set; }
        public float? prevClosePrice { get; set; }
        public double? limitDownPrice { get; set; }
        public double? limitUpPrice { get; set; }
        public long? totalVolume { get; set; }
        public long? volume { get; set; }
        public long? volume24h { get; set; }
        public long? prevTotalTurnover { get; set; }
        public long? totalTurnover { get; set; }
        public long? turnover { get; set; }
        public long? turnover24h { get; set; }
        public long? homeNotional24h { get; set; }
        public long? foreignNotional24h { get; set; }
        public double? prevPrice24h { get; set; }
        public float? vwap { get; set; }
        public float? highPrice { get; set; }
        public float? lowPrice { get; set; }
        public double? lastPrice { get; set; }
        public double? lastPriceProtected { get; set; }
        public string? lastTickDirection { get; set; }
        public long? lastChangePcnt { get; set; }
        public float? bidPrice { get; set; }
        public float? midPrice { get; set; }
        public float? askPrice { get; set; }
        public float? impactBidPrice { get; set; }
        public long? impactMidPrice { get; set; }
        public long? impactAskPrice { get; set; }
        public bool? hasLiquidity { get; set; }
        public long? openInterest { get; set; }
        public long? openValue { get; set; }
        public string? fairMethod { get; set; }
        public float? fairBasisRate { get; set; }
        public long? fairBasis { get; set; }
        public double? fairPrice { get; set; }
        public string? markMethod { get; set; }
        public double? markPrice { get; set; }
        public double? indicativeSettlePrice { get; set; }
        public long? settledPriceAdjustmentRate { get; set; }
        public double? settledPrice { get; set; }
        public DateTime? timestamp { get; set; }

    }
}