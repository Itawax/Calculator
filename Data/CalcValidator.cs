namespace Calculator.Data
{
    public class CalcValidator
    {
        char LastSymbol;
        bool ContainsOperator;
        List<char> OperSymbols;
        bool ContainsPoint;
        public CalcValidator() 
        {
            LastSymbol = ' ';
            ContainsOperator = false;
            ContainsPoint = false;
            OperSymbols = new List<char>() { '+', '-', '*', '/' };
        }

        public bool ValidateInput(char matSymbol)
        {
            if (matSymbol == ',')
            {
                if (LastSymbol == ',' || OperSymbols.Contains(LastSymbol) || ContainsPoint)
                    return false;
                else
                    ContainsPoint = true;

            }

            if (OperSymbols.Contains(matSymbol))
            {
                if (ContainsOperator || OperSymbols.Contains(LastSymbol) || LastSymbol == ' ')
                    return false;
                else
                {
                    ContainsOperator = true;
                    ContainsPoint = false;
                }
            }            
            
            LastSymbol = matSymbol;
            return true;
        }

        public void Reset()
        {
            ContainsOperator= false;
            ContainsPoint = false;
            LastSymbol = ' ';
        }

    }
}
