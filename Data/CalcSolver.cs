namespace Calculator.Data
{
    public class CalcSolver
    {
        public static double Solve(string matExpression)
        {
            List<char> OperSymbols = new List<char>() { '+', '-', '*', '/' };
            char operSymbol = ' ';
            double num1, num2, result = 0;

            foreach (char os in OperSymbols)
            {
                if (matExpression.Contains(os))
                {
                    operSymbol = os;
                    break;
                }
            }

            if (operSymbol == ' ')
                //SendError(new Exception("No operator"))
                throw new Exception("No operator");

            string[] matParts = matExpression.Split(operSymbol);

            if (matParts.Length != 2)
                //SendError(new Exception("Invalid number of numbers"))
                throw new Exception("Invalid number of numbers");

            double.TryParse(matParts[0], out num1);
            double.TryParse(matParts[1], out num2);

            switch (operSymbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    //SendError(new Exception("Invalid operator"))
                    throw new Exception("Invalid operator");
            }

            return result;
        }
    }
}
