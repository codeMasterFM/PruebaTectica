using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Db.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "instruments",
                columns: table => new
                {
                    symbol = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rootSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    listing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    front = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    settle = table.Column<DateTime>(type: "datetime2", nullable: false),
                    listedSettle = table.Column<DateTime>(type: "datetime2", nullable: false),
                    positionCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    underlying = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quoteCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    underlyingSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    referenceSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    calcInterval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    publishInterval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    publishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maxOrderQty = table.Column<int>(type: "int", nullable: false),
                    maxPrice = table.Column<int>(type: "int", nullable: false),
                    lotSize = table.Column<int>(type: "int", nullable: false),
                    tickSize = table.Column<double>(type: "float", nullable: false),
                    multiplier = table.Column<int>(type: "int", nullable: false),
                    settlCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    underlyingToPositionMultiplier = table.Column<int>(type: "int", nullable: false),
                    underlyingToSettleMultiplier = table.Column<int>(type: "int", nullable: false),
                    quoteToSettleMultiplier = table.Column<int>(type: "int", nullable: false),
                    isQuanto = table.Column<bool>(type: "bit", nullable: false),
                    isInverse = table.Column<bool>(type: "bit", nullable: false),
                    initMargin = table.Column<double>(type: "float", nullable: false),
                    maintMargin = table.Column<double>(type: "float", nullable: false),
                    riskLimit = table.Column<long>(type: "bigint", nullable: false),
                    riskStep = table.Column<long>(type: "bigint", nullable: false),
                    limit = table.Column<double>(type: "float", nullable: false),
                    taxed = table.Column<bool>(type: "bit", nullable: false),
                    deleverage = table.Column<bool>(type: "bit", nullable: false),
                    makerFee = table.Column<double>(type: "float", nullable: false),
                    takerFee = table.Column<double>(type: "float", nullable: false),
                    settlementFee = table.Column<double>(type: "float", nullable: false),
                    fundingBaseSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fundingQuoteSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fundingPremiumSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fundingTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fundingInterval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fundingRate = table.Column<float>(type: "real", nullable: false),
                    rebalanceTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rebalanceInterval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prevClosePrice = table.Column<int>(type: "int", nullable: false),
                    limitDownPrice = table.Column<double>(type: "float", nullable: false),
                    limitUpPrice = table.Column<double>(type: "float", nullable: false),
                    totalVolume = table.Column<int>(type: "int", nullable: false),
                    volume = table.Column<int>(type: "int", nullable: false),
                    volume24h = table.Column<int>(type: "int", nullable: false),
                    prevTotalTurnover = table.Column<int>(type: "int", nullable: false),
                    totalTurnover = table.Column<int>(type: "int", nullable: false),
                    turnover = table.Column<int>(type: "int", nullable: false),
                    turnover24h = table.Column<int>(type: "int", nullable: false),
                    homeNotional24h = table.Column<int>(type: "int", nullable: false),
                    foreignNotional24h = table.Column<int>(type: "int", nullable: false),
                    prevPrice24h = table.Column<double>(type: "float", nullable: false),
                    vwap = table.Column<float>(type: "real", nullable: false),
                    highPrice = table.Column<float>(type: "real", nullable: false),
                    lowPrice = table.Column<float>(type: "real", nullable: false),
                    lastPrice = table.Column<double>(type: "float", nullable: false),
                    lastPriceProtected = table.Column<double>(type: "float", nullable: false),
                    lastTickDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastChangePcnt = table.Column<int>(type: "int", nullable: false),
                    bidPrice = table.Column<float>(type: "real", nullable: false),
                    midPrice = table.Column<float>(type: "real", nullable: false),
                    askPrice = table.Column<float>(type: "real", nullable: false),
                    impactBidPrice = table.Column<float>(type: "real", nullable: false),
                    impactMidPrice = table.Column<int>(type: "int", nullable: false),
                    impactAskPrice = table.Column<int>(type: "int", nullable: false),
                    hasLiquidity = table.Column<bool>(type: "bit", nullable: false),
                    openInterest = table.Column<int>(type: "int", nullable: false),
                    openValue = table.Column<int>(type: "int", nullable: false),
                    fairMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fairBasisRate = table.Column<float>(type: "real", nullable: false),
                    fairBasis = table.Column<int>(type: "int", nullable: false),
                    fairPrice = table.Column<double>(type: "float", nullable: false),
                    markMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    markPrice = table.Column<double>(type: "float", nullable: false),
                    indicativeSettlePrice = table.Column<double>(type: "float", nullable: false),
                    settledPriceAdjustmentRate = table.Column<int>(type: "int", nullable: false),
                    settledPrice = table.Column<double>(type: "float", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instruments", x => x.symbol);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instruments");
        }
    }
}
