namespace xUnitTutorial
{
    public class Calculator
    {
        private CalculatorState _state = CalculatorState.Cleared;

        public decimal Value { get; private set; } = 0;

        public decimal Add(decimal value)
        {
            _state = CalculatorState.Active;
            return Value += value;
        }

        public decimal Subtract(decimal value)
        {
            _state = CalculatorState.Active;
            return Value -= value;
        }
    }

    public enum CalculatorState
    {
        Active,
        Cleared
    }
}