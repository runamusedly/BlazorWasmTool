namespace BlazorWasmCalculator.Services
{
    public class CalculatorState
    {
        public string CurrentInput { get; set; } = "";
        public double PreviousValue { get; set; } = 0;
        public string? Operator { get; set; } = null;
        public double Result { get; set; } = 0;
        public string? ProcessCalc { get; set; } = null;

        public bool IsShowingResult { get; set; } = false;
        public bool IsShowingWarning { get; set; } = false;
        public string WarningMessage { get; set; } = "";
    }
}
