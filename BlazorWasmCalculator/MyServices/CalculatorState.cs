namespace BlazorWasmCalculator.Services
{
    public class CalculatorState
    {
        public string CurrentInput { get; set; } = "0";
        public double PreviousValue { get; set; } = 0;
        public string? Operator { get; set; } = null;
        public double Result { get; set; } = 0;
        public string? ProcessCalc { get; set; } = null;

        public bool IsShowingResult { get; set; } = false;
        public bool ShowLimitWarning { get; set; } = false;
        public string WarningMessage { get; set; } = "";
    }
}
