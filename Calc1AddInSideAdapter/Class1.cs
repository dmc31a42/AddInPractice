using System.AddIn.Pipeline;
using Calc1Contract;
using Calc1AddInView;


namespace Calc1AddInSideAdapter
{
    [AddInAdapter]
    public class CalculatorViewToContractAddInSideAdapter : ContractBase, ICalc1Contract
    {
        private ICalculator _view;

        public CalculatorViewToContractAddInSideAdapter(ICalculator view) :base()
        {
            _view = view;
        }

        double ICalc1Contract.Add(double a, double b)
        {
            return _view.Add(a, b);
        }

        double ICalc1Contract.Divide(double a, double b)
        {
            return _view.Divide(a, b);
        }

        double ICalc1Contract.Multiply(double a, double b)
        {
            return _view.Multiply(a, b);
        }

        double ICalc1Contract.Subtract(double a, double b)
        {
            return _view.Subtract(a, b);
        }
    }
}
