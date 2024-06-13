namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerExpression
    {
        public QScreenerFilterOperand LeftOperand { get; set; }

        public QScreenerFilterOperand RightOperand { get; set; }

        public QScreenerExpressionCondition? Operator { get; set; }
    }
}
